<!DOCTYPE html>
<html lang="ko">
<head>
    <meta charset="UTF-8">
</head>
<body>
    <h1>13주차 라벨링 프로젝트 환경 재설정 </h1>

<p>
        <code>C:\Users\COM\Desktop\C-programming\13week\Labeling</code> 경로에 위치한 
        <strong>13주차 라벨링 프로젝트</strong>의 경우, 
        <code>packages</code> 폴더가 제거되어 <code>도구탭</code>  >>  <code>NuGet 패키지관리자</code> >>  <code>솔루션용NuGet관리 </code> 탭으로 들어가 다시 설치
    </p>

<h2>1. NuGet 패키지를 통한 OpenCV 재설치 방법</h2>
    <ol>
        <li>Visual Studio를 실행</li>
        <li>
            메뉴 상단에서 <strong>도구 &gt; NuGet 패키지 관리자 &gt; NuGet 패키지 관리자 콘솔</strong> 
            또는 <strong>NuGet 패키지 관리</strong>를 선택
        </li>
        <li>아래의 4가지 패키지를 다시 설치:
            <ul>
                <li>OpenCV4</li>
                <li>OpenCV4.runtime.win</li>
                <li>OpenCV4.Windows</li>
                <li>OpenCV4.Extensions</li>
            </ul>
        </li>
    </ol>

<h2>2. 프로젝트 플랫폼 설정 변경 (x64)</h2>
    <ol>
        <li>Visual Studio의 솔루션 탐색기에서 해당 프로젝트를 선택</li>
        <li>
            상단 메뉴에서 <strong>프로젝트 &gt; 프로젝트 속성</strong>을 클릭
            (메뉴의 가장 아래에 위치해있음)
        </li>
        <li>좌측 메뉴에서 <strong>빌드</strong> 탭을 클릭</li>
        <li><strong>플랫폼 대상</strong>을 <code>x32</code>에서 <code>x64</code>로 변경</li>
        <li>변경사항을 저장한 뒤, 프로젝트를 다시 빌드</li>
    </ol>
</body>
</html>
