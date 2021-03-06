GameView = class(View)

local Text = require("TMPro.TMP_Text")

function GameView:ctor()
    self.isInitialized = false
end

function GameView:Initialize()
    coroutine.start(GameView.InitializeAsync, self)
end

function GameView:InitializeAsync()
    local canvasHandle = LuaAddressables.LoadAssetAsync("Jump_Jump/Prefabs/Canvas.prefab")
    while not canvasHandle.IsDone do
        coroutine.step()
    end
    self.canvas = GameObject.Instantiate(canvasHandle.Result)
    self.startMenu = self.canvas.transform:Find("StartMenu").gameObject
    self.endMenu = self.canvas.transform:Find("EndMenu").gameObject
    self.startButton = self.startMenu.transform:Find("StartButton").gameObject
    self.exitButton = self.startMenu.transform:Find("ExitButton").gameObject
    self.restartButton = self.endMenu.transform:Find("RestartButton").gameObject
    self.scoreText = self.endMenu.transform:Find("Score/Text"):GetComponent(typeof(Text))
    self:OpenStartMenu()
    self.isInitialized = true
end

function GameView:OpenStartMenu()
    self.startMenu.transform.localPosition = Vector3.zero
    self:CloseEndMenu()
end

function GameView:CloseStartMenu()
    self.startMenu.transform.localPosition = self.startMenu.transform.localPosition + Vector3.up * 1080
end

function GameView:OpenEndMenu(score)
    self.endMenu.transform.localPosition = Vector3.zero
    self.scoreText.text = score
    self:CloseStartMenu()
end

function GameView:CloseEndMenu()
    self.endMenu.transform.localPosition = self.endMenu.transform.localPosition + Vector3.up * 1080
end

return GameView
