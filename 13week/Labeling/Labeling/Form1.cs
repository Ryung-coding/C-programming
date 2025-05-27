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
        int length = 0;
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

            // 윤곽선 그리기
            {
                //// 엣지를 그릴 검은색 배경의 3채널 이미지 만들기
                //Mat edgeOutput = new Mat(matBin.Size(), MatType.CV_8UC3, Scalar.Black);
                //// 그리기
                //for (int i = 0; i < contours.Length; i++)
                //{
                //    Cv2.DrawContours(edgeOutput, contours, i, new Scalar(255, 255, 255), 1);
                //}
                //picResult.Image = edgeOutput.ToBitmap();
            }
            // 혹은 아래와 같이 Graphics를 이용하여 그릴수도 있음
            // (자료구조를 파악할 수 있지만 느림)
            {
                Graphics grp = picResult.CreateGraphics();
                grp.Clear(Color.Black);
                for (int i = 0; i < contours.Length; i++)
                {
                    for (int j = 0; j < contours[i].Length - 1; j++)
                    {
                        //grp.DrawEllipse(new Pen(Color.White), contours[i][j].X, contours[i][j].Y, 1, 1);
                        grp.DrawLine(new Pen(Color.White), contours[i][j].X, contours[i][j].Y,contours[i][j + 1].X, contours[i][j + 1].Y);
                        length += (contours[i][j + 1].X - contours[i][j].X) * (contours[i][j + 1].X - contours[i][j].X) + (contours[i][j + 1].Y - contours[i][j].Y) * (contours[i][j + 1].Y - contours[i][j].Y);
                    }
                    grp.DrawLine(new Pen(Color.White), contours[i][contours[i].Length - 1].X, contours[i][contours[i].Length - 1].Y,contours[i][0].X, contours[i][0].Y);
                    length += (contours[i][contours[i].Length - 1].X - contours[i][0].X) * (contours[i][contours[i].Length - 1].X - contours[i][0].X) + (contours[i][contours[i].Length - 1].Y - contours[i][0].Y) * (contours[i][contours[i].Length - 1].Y - contours[i][0].Y);
                    txtLabelingResult.Text = "길이 " + string.Format("{0:0.000}", length) + "\r\n" + "\r\n";
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
            //이게 군집을 잡아주는 함수다

            double dtime = Util.TimeInSeconds(stime);

            GetLabelMat(nLabels, labels, stats, centroids, out Mat colorMap,
                        out int[] area, out double[] xcen, out double[] ycen);
            picResult.Image = colorMap.ToBitmap();

            // 결과 텍스트창에 표시
            txtLabelingResult.Text = "라벨링시간(초)= " + string.Format("{0:0.000}", dtime) + "\r\n" + "\r\n";

            for (int i = 1; i < nLabels; i++)
            {
                txtLabelingResult.Text += "라벨번호= " + Convert.ToString(i).PadLeft(2) + "  " +
                                        "면적= " + Convert.ToString(area[i]).PadLeft(5) + "  " +
                                        "중심= " + string.Format("{0:0.00}", xcen[i]) + ", " +
                                                    string.Format("{0:0.00}", ycen[i]) + "\r\n";
            }
        }

        private void GetLabelMat(int nLabels,Mat labels, Mat stats, Mat centroids,out Mat colorMap, out int[] area,out double[] xcen, out double[] ycen)
        {
            Random rnd = new Random();

            // 컬러 시각화용 Mat
            colorMap = new Mat(labels.Size(), MatType.CV_8UC3);

            // 면적과 중심
            area = new int[nLabels];
            xcen = new double[nLabels];
            ycen = new double[nLabels];

            // 라벨 번호에 대한 색상
            Vec3b[] labelColors = new Vec3b[nLabels];
            labelColors[0] = new Vec3b(0, 0, 0);          // 배경은 검정색

            for (int i = 1; i < nLabels; i++)
            {
                labelColors[i] = new Vec3b(
                                    (byte)rnd.Next(256),
                                    (byte)rnd.Next(256),
                                    (byte)rnd.Next(256)); // 각 라벨은 랜덤 컬러
            }

            // 라벨 번호 -> 컬러로 변환
            for (int y = 0; y < labels.Rows; y++)
            {
                for (int x = 0; x < labels.Cols; x++)
                {
                    int label = labels.Get<int>(y, x);
                    colorMap.Set<Vec3b>(y, x, labelColors[label]);
                }
            }

            // 각 레이블에 대해 사각형 + 중심점 표시
            for (int i = 1; i < nLabels; i++)
            {
                // stats: xbox, ybox, width, height, areaLabel
                int xbox = stats.Get<int>(i, 0);
                int ybox = stats.Get<int>(i, 1);
                int width = stats.Get<int>(i, 2);
                int height = stats.Get<int>(i, 3);
                int areaLabel = stats.Get<int>(i, 4);

                // 중심점
                double cx = centroids.Get<double>(i, 0);
                double cy = centroids.Get<double>(i, 1);

                // 출력배열에 저장
                area[i] = areaLabel;
                xcen[i] = cx;
                ycen[i] = cy;

                // 사각형
                Cv2.Rectangle(colorMap, new Rect(xbox, ybox, width, height), new Scalar(255, 255, 255), 1);

                // 중심점 (십자 + 텍스트)
                int len = 3;
                Cv2.Line(colorMap, (int)cx - len, (int)cy, (int)cx + len, (int)cy, new Scalar(0, 255, 255));
                Cv2.Line(colorMap, (int)cx, (int)cy - len, (int)cx, (int)cy + len, new Scalar(0, 255, 255));
                Cv2.PutText(colorMap, i.ToString(), new OpenCvSharp.Point((int)cx + 5, (int)cy - 5),
                            HersheyFonts.HersheySimplex, 0.5, new Scalar(255, 255, 255), 1);
            }
        }

    }
}
