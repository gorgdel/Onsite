# Configure Power Settings
# display never sleep
POWERCFG /SETACVALUEINDEX SCHEME_BALANCED SUB_VIDEO VIDEOIDLE 0
# never sleep
POWERCFG /SETACVALUEINDEX SCHEME_BALANCED SUB_SLEEP STANDBYIDLE 0
# never hibernate
POWERCFG /SETACVALUEINDEX SCHEME_BALANCED SUB_SLEEP HIBERNATEIDLE 0
# Power button do nothing
POWERCFG /SETACVALUEINDEX SCHEME_BALANCED SUB_BUTTONS PBUTTONACTION 0
# sleep button do nothing
POWERCFG /SETACVALUEINDEX SCHEME_BALANCED SUB_BUTTONS 96996bc0-ad50-47ec-923b-6f41874dd9eb 0
# activate scheme
POWERCFG /SETACTIVE SCHEME_BALANCED