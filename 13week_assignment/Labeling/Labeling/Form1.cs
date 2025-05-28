using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Labeling
{
    public partial class Form1 : Form
    {
        VideoCapture gCap;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            string fname = openFileDialog.FileName;
            Mat mat = Cv2.ImRead(fname);
            picSrc.Image = mat.ToBitmap();
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            if (timCam.Enabled == false)
            {
                int idxcam = 0;
                gCap = new VideoCapture(idxcam);

                // 필요하면 해상도 설정
                gCap.FrameWidth = 1280;
                gCap.FrameHeight = 1024;

                if (gCap.IsOpened() == false) return;

                timCam.Interval = 33;   //초당 30프레임 설정
                timCam.Enabled = true;
            }
            else
            {
                // 비활성
                timCam.Enabled = false;
                chkCam.Checked = false;
                if (gCap != null) gCap.Dispose();
            }
        }

        private void timCam_Tick(object sender, EventArgs e)
        {
            Mat mat = new Mat();

            //-- (1) 방법 1 : Grab() + Retrieve()
            gCap.Grab();           // Grab()은 카메라에서 영상을 가져오고, 메모리에 저장함
            gCap.Retrieve(mat);    // Retrieve()는 메모리에 저장된 영상을 꺼내서 mat에 저장함

            //-- (2) 방법 2 : Read() 사용 (= Grab() + Retrieve() )
            //gCap.Read(mat);

            // PictueBox에 표시
            picSrc.Image = mat.ToBitmap();

            // 깜박거림 표시
            chkCam.Checked = !chkCam.Checked;

            // Garbage Collector
            //GC.Collect(); // 이 라인 살리면 메모리 쌓이지 않음
        }

        private void btnToGray_Click(object sender, EventArgs e)
        {
            if (picSrc.Image == null) return;

            // picSrc의 Image를 추출하여 matSrc에 저장
            Bitmap bmp = picSrc.Image as Bitmap;
            Mat matSrc = BitmapConverter.ToMat(bmp);

            // (OpenCV 함수를 이용하여) matSrc를 Gray로 변환
            Mat matGray = new Mat();
            Cv2.CvtColor(matSrc, matGray, ColorConversionCodes.BGR2GRAY);
            picGray.Image = matGray.ToBitmap();
        }

        private void btnToBin_Click(object sender, EventArgs e)
        {
            if (picGray.Image == null) return;

            // picGray의 Image를 추출하여 matGray에 저장
            Bitmap bmp = picGray.Image as Bitmap;
            Mat matGray = BitmapConverter.ToMat(bmp);

            // (OpenCV 함수를 이용하여) matGray를 Binary로 변환
            if (radOtus.Checked)
            {
                Mat matBin = new Mat();
                Cv2.Threshold(matGray, matBin, 0, 255, ThresholdTypes.Otsu);
                picBin.Image = matBin.ToBitmap();
            }
            else if (radBin.Checked)
            {
                double thresh = hscThreshold.Value;
                Mat matBin = new Mat(); // Create a new Mat object to store the result
                Cv2.Threshold(matGray, matBin, thresh, 255, ThresholdTypes.Binary);
                picBin.Image = matBin.ToBitmap();
            }
        }

        private void hscThreshold_Scroll(object sender, ScrollEventArgs e)
        {
            lblThreshold.Text = Convert.ToString(hscThreshold.Value);
            btnToBin.PerformClick();
        }

        private void radOtus_CheckedChanged(object sender, EventArgs e)
        {
            btnToBin.PerformClick();
        }

        private void radBin_CheckedChanged(object sender, EventArgs e)
        {
            btnToBin.PerformClick();
        }

        private void btnCannyEdge_Click(object sender, EventArgs e)
        {
            if (picGray.Image == null) return;

            // picGray의 Image를 추출하여 matGray에 저장
            Bitmap bmp = picGray.Image as Bitmap;
            Mat matGray = BitmapConverter.ToMat(bmp);

            // (OpenCV 함수를 이용하여) Canny Edge 영상 얻기
            int threshold = hscThreshold.Value;
            Mat matEdge = new Mat();
            Cv2.Canny(matGray, matEdge, threshold, 255);
            picResult.Image = matEdge.ToBitmap();
        }

        private void btnContour_Click(object sender, EventArgs e)
        {
            if (picBin.Image == null) return;
            // picBin Image를 추출하여 matBin에 저장
            Bitmap bmp = picBin.Image as Bitmap;
            Mat matBin = BitmapConverter.ToMat(bmp);

            // Contour(윤곽선) 찾기
            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchy;
            Cv2.FindContours(matBin, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            Graphics grp = picResult.CreateGraphics();

            for (int i = 0; i < contours.Length; i++)
            {
                using (Pen pen = new Pen(Color.White))
                {
                    // 윤곽선 그리기
                    for (int j = 0; j < contours[i].Length - 1; j++)
                    {
                        grp.DrawLine(pen,
                                     contours[i][j].X, contours[i][j].Y,
                                     contours[i][j + 1].X, contours[i][j + 1].Y);
                    }
                    grp.DrawLine(pen,
                                 contours[i][contours[i].Length - 1].X,
                                 contours[i][contours[i].Length - 1].Y,
                                 contours[i][0].X,
                                 contours[i][0].Y);
                }
            }
        }

        private void btnLabeling_Click(object sender, EventArgs e)
        {
            if (picBin.Image == null) return;

            // picBin의 Image를 추출하여 matBin에 저장
            Bitmap bmp = picBin.Image as Bitmap;
            Mat matBin = BitmapConverter.ToMat(bmp);

            // matBin을 Labeling
            DateTime stime = DateTime.Now;

            Mat labels = new Mat();
            Mat stats = new Mat();
            Mat centroids = new Mat();
            int nLabels = Cv2.ConnectedComponentsWithStats(matBin, labels, stats, centroids);

            double dtime = Util.TimeInSeconds(stime);

            // 컬러맵과 통계 데이터 생성
            GetLabelMat(nLabels, labels, stats, centroids,
                        out Mat colorMap, out int[] area,
                        out double[] xcen, out double[] ycen);
            picResult.Image = colorMap.ToBitmap();

            // 결과 텍스트 초기화
            txtLabelingResult.Text = "라벨링시간(초)= " + string.Format("{0:0.000}", dtime) + "\r\n\r\n";

            // 도형 분류 파라미터
            double desiredCircleRatio = 1 - 0.25 * 3.141592;
            double tolerance = 0.05;

            // 각 라벨별 정보 및 도형명 표시
            for (int i = 1; i < nLabels; i++)
            {
                // 분류용 ROI 박스
                Rect roiRect = new Rect(
                    stats.Get<int>(i, 0), stats.Get<int>(i, 1),
                    stats.Get<int>(i, 2), stats.Get<int>(i, 3));

                // 도형명 판별
                string shape = ClassifyShape(labels, i, roiRect,
                                             area[i], desiredCircleRatio, tolerance);

                // 텍스트로 출력: 라벨번호, 도형명, 면적, 중심
                txtLabelingResult.Text +=
                    $"라벨번호= {i:D2} ({shape})  면적= {area[i],5}  중심= {xcen[i]:0.00},{ycen[i]:0.00}" + "\r\n\r\n";
            }
        }


        private void GetLabelMat(int nLabels, Mat labels, Mat stats, Mat centroids,out Mat colorMap, out int[] area,out double[] xcen, out double[] ycen)
        {
            // 컬러맵 초기화
            colorMap = new Mat(labels.Size(), MatType.CV_8UC3);

            // 라벨별 색상 배열 (배경은 검정)
            Vec3b[] labelColors = new Vec3b[nLabels];
            labelColors[0] = new Vec3b(0, 0, 0);

            area = new int[nLabels];
            xcen = new double[nLabels];
            ycen = new double[nLabels];

            double desiredCircleRatio = 1 - 0.25 * 3.141592;
            double tolerance = 0.05;

            for (int i = 1; i < nLabels; i++)
            {
                int boxX = stats.Get<int>(i, 0);
                int boxY = stats.Get<int>(i, 1);
                int boxWidth = stats.Get<int>(i, 2);
                int boxHeight = stats.Get<int>(i, 3);
                int labelArea = stats.Get<int>(i, 4);

                // 중심 좌표 저장
                area[i] = labelArea;
                xcen[i] = centroids.Get<double>(i, 0);
                ycen[i] = centroids.Get<double>(i, 1);

                string shape = ClassifyShape(labels, i, new Rect(boxX, boxY, boxWidth, boxHeight),
                                              labelArea, desiredCircleRatio, tolerance);
                // 색상 결정: Circle->Red, Triangle->Green, Rectangle->Blue, Other->White
                switch (shape)
                {
                    case "Circle": labelColors[i] = new Vec3b(0, 0, 255); break;
                    case "Triangle": labelColors[i] = new Vec3b(0, 255, 0); break;
                    case "Rectangle": labelColors[i] = new Vec3b(255, 0, 0); break;
                    default: labelColors[i] = new Vec3b(255, 255, 255); break;
                }
            }

            // 라벨맵을 컬러맵으로 변환
            for (int y = 0; y < labels.Rows; y++)
            {
                for (int x = 0; x < labels.Cols; x++)
                {
                    int lbl = labels.Get<int>(y, x);
                    colorMap.Set<Vec3b>(y, x, labelColors[lbl]);
                }
            }

            // 경계 사각형 및 중심점 표시
            for (int i = 1; i < nLabels; i++)
            {
                int boxX = stats.Get<int>(i, 0);
                int boxY = stats.Get<int>(i, 1);
                int boxWidth = stats.Get<int>(i, 2);
                int boxHeight = stats.Get<int>(i, 3);

                // 테두리 그리기
                Cv2.Rectangle(colorMap, new Rect(boxX, boxY, boxWidth, boxHeight), new Scalar(255, 255, 255), 1);

                // 라벨 번호 텍스트
                Cv2.PutText(colorMap, i.ToString(),
                            new OpenCvSharp.Point((int)xcen[i] + 5, (int)ycen[i] - 5),
                            HersheyFonts.HersheySimplex, 0.5, new Scalar(255, 255, 255), 1);
            }
        }
        private string ClassifyShape(Mat labels, int labelIndex, Rect roiRect,int label_area, double desired_circle_ratio, double uncertanty)
        {
            // 1) 원형 판별 (영역 비율)
            double avg_box_size = (roiRect.Width + roiRect.Height) / 2.0;
            double box_area = avg_box_size * avg_box_size;
            double zeroCount = box_area - label_area;
            double ratio = box_area > 0 ? zeroCount / box_area : 0;
            if (Math.Abs(ratio - desired_circle_ratio) < uncertanty) return "Circle";

            Mat mask = new Mat(labels.Size(), MatType.CV_8UC1);
            Cv2.InRange(labels, new Scalar(labelIndex), new Scalar(labelIndex), mask);
            Mat roiMask = new Mat(mask, roiRect);

            OpenCvSharp.Point[][] contours;
            Cv2.FindContours(roiMask, out contours, out _,
                             RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            if (contours.Length > 0)
            {
                var cnt = contours[0];
                var approx = Cv2.ApproxPolyDP(cnt, Cv2.ArcLength(cnt, true) * 0.02, true);
                if (approx.Length == 3)
                    return "Triangle";
                if (approx.Length == 4)
                    return "Rectangle";
            }
            return "Other";
        }


    }
}
