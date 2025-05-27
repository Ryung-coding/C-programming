<!DOCTYPE html>
<html lang="ko">
<head>
    <meta charset="UTF-8">
    <title>프로젝트 설정 안내</title>
</head>
<body>
    <h1>프로젝트 환경 재설정 안내</h1>

    <p>
        <code>C:\Users\COM\Desktop\C-programming\13week\Labeling</code> 경로에 위치한 프로젝트에서
        <strong>package 폴더가 제거</strong>되어 NuGet 패키지를 다시 설치해야 합니다.
    </p>

    <h2>1. NuGet 패키지 재설치 방법</h2>
    <ol>
        <li>
            Visual Studio를 실행합니다.
        </li>
        <li>
            메뉴 상단의 <strong>도구 &gt; NuGet 패키지 관리자 &gt; 패키지 관리자 콘솔</strong> 또는 
            <strong>NuGet 패키지 관리</strong>를 선택합니다.
        </li>
        <li>
            아래의 4가지 패키지를 다시 설치합니다:
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
        <li>Visual Studio에서 솔루션 탐색기에서 프로젝트를 선택합니다.</li>
        <li>상단 메뉴의 <strong>프로젝트 &gt; 프로젝트 속성</strong>을 클릭합니다. (가장 아래에 위치)</li>
        <li>좌측 메뉴에서 <strong>빌드</strong>를 선택합니다.</li>
        <li>플랫폼 타겟을 <strong>x64</strong>로 변경합니다.</li>
        <li>저장 후 프로젝트를 다시 빌드합니다.</li>
    </ol>

    <p>위 설정을 완료하면 프로젝트가 정상적으로 작동합니다.</p>
</body>
</html>
