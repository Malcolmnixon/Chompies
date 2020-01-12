
SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
UNITY=/home/sam/Unity/Hub/Editor/2019.3.0f3/Editor/Unity
DATE=$(date)

$UNITY -quit -batchmode -projectPath "$SCRIPT_DIR" -executeMethod Builder.BuildAll  -logfile "$SCRIPT_DIR/log/build.log"
# $DATE.log"
