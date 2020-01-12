SET "UNITY_DIR=C:\Program Files\Unity\Hub\Editor\2019.3.0f3\Editor"
SET "PROJECT_DIR=%~p0"

"%UNITY_DIR%\Unity.exe" -quit -batchmode -projectPath "%PROJECT_DIR%" -executeMethod "Builder.BuildWin64"  -logfile "Build/Win/build.log"
