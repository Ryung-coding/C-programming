<!DOCTYPE html>
<html lang="ko">
<head>
    <meta charset="UTF-8">
</head>
<body>
    <h1>13주차 라벨링 프로젝트 환경 재설정 안내</h1>

<p>
        <code>C:\Users\COM\Desktop\C-programming\13week\Labeling</code> 경로에 위치한 
        <strong>13주차 라벨링 프로젝트</strong>의 경우, 
        <code>packages</code> 폴더가 제거되어 NuGet 패키지를 다시 설치해야 합니다.
    </p>

<h2>1. NuGet 패키지 재설치 방법</h2>
    <ol>
        <li>Visual Studio를 실행합니다.</li>
        <li>
            메뉴 상단에서 <strong>도구 &gt; NuGet 패키지 관리자 &gt; NuGet 패키지 관리자 콘솔</strong> 
            또는 <strong>NuGet 패키지 관리</strong>를 선택합니다.
        </li>
        <li>아래의 4가지 패키지를 다시 설치합니다:
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
        <li>Visual Studio의 솔루션 탐색기에서 해당 프로젝트를 선택합니다.</li>
        <li>
            상단 메뉴에서 <strong>프로젝트 &gt; 프로젝트 속성</strong>을 클릭합니다. 
            (메뉴의 가장 아래에 위치해 있습니다)
        </li>
        <li>좌측 메뉴에서 <strong>빌드</strong> 탭을 클릭합니다.</li>
        <li><strong>플랫폼 대상</strong>을 <code>x64</code>로 변경합니다.</li>
        <li>변경사항을 저장한 뒤, 프로젝트를 다시 빌드합니다.</li>
    </ol>

<p>
        위 과정을 완료하면 프로젝트가 정상적으로 작동합니다. 문제가 발생할 경우, 
        패키지 설치 여부와 플랫폼 설정을 다시 확인해 주세요.
    </p>
</body>
</html>
