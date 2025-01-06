此壓縮包內有如下文件夾：
360video		360視頻及圖片的放置處

Prefab		調整好的Prefab，需要拖入Hierarchy中使用，其中，“360Video”是遊戲相關的360視頻；“360OtherVideo”及“System”是用於遊戲開頭的隨機展示。

RenderTexture	將360視頻轉換成天空盒的中轉站，沒什麼事可以不用搞它

Scenes		裡面的scenes是使用示範，會顯示“360OtherVideo”及“System”的應用實例，每分鐘改變一次

Script		代碼，“RotateCamera”用於控制鏡頭，模擬使用者戴上vr後會看見的事物；“RandomSkybox”與“360OtherVideo”及“System”關聯，用於隨機改變天空盒；“ChangeSkyboxOnTrigger”是我特意留下的代碼，原理是玩家觸碰到物體後轉換指定天空盒，但未經測試

Skybox		天空盒存放處，文件名與360視頻及圖片名稱一致