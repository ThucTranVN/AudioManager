# AudioManager
Add new audio file to Resources>Audio>BGM (for background music) or Resources>Audio>SE (for sound effect) 
Then select Tools>Create>Audio Name to create AUDIO file

Usage:
- Play background music:
AudioManager.Instance.PlayBGM(AUDIO.Background_Music_Name);
- Play sound effect:
AudioManager.Instance.PlaySE(AUDIO.Sound_Effect_Name);
- Change background music volume:
AudioManager.Instance.ChangeBGMVolume(value);
- Change sound effect volume:
 AudioManager.Instance.ChangeSEVolume(value);
 - Mute background music volume:
 AudioManager.Instance.MuteBGM(value);
 - Mute sound effect volume:
 AudioManager.Instance.MuteSE(value);
