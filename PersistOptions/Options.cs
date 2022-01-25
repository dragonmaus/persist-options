using StardewValley;

namespace PersistOptions
{
    internal class Options
    {
        internal Options() => SetFromGame();

        internal void LoadToGame()
        {
            StardewValley.Options gameOptions = Game1.options;

            // general
            gameOptions.autoRun = autoRun;
            gameOptions.showPortraits = showPortraits;
            gameOptions.showMerchantPortraits = showMerchantPortraits;
            gameOptions.alwaysShowToolHitLocation = alwaysShowToolHitLocation;
            gameOptions.hideToolHitLocationWhenInMotion = hideToolHitLocationWhenInMotion;
            gameOptions.pauseWhenOutOfFocus = pauseWhenOutOfFocus;
            gameOptions.showPlacementTileForGamepad = showPlacementTileForGamepad;
            gameOptions.snappyMenus = snappyMenus;
            gameOptions.ipConnectionsEnabled = ipConnectionsEnabled;
            gameOptions.enableServer = enableServer;
            gameOptions.enableFarmhandCreation = enableFarmhandCreation;
            gameOptions.showAdvancedCraftingInformation = showAdvancedCraftingInformation;
            gameOptions.showMPEndOfNightReadyStatus = showMPEndOfNightReadyStatus;
            gameOptions.useLegacySlingshotFiring = useLegacySlingshotFiring;

            // sounds
            gameOptions.dialogueTyping = dialogueTyping;
            gameOptions.playFootstepSounds = playFootstepSounds;
            gameOptions.ambientOnlyToggle = ambientOnlyToggle;
            gameOptions.muteAnimalSounds = muteAnimalSounds;
            gameOptions.musicVolumeLevel = musicVolumeLevel;
            gameOptions.soundVolumeLevel = soundVolumeLevel;
            gameOptions.footstepVolumeLevel = footstepVolumeLevel;
            gameOptions.ambientVolumeLevel = ambientVolumeLevel;

            // graphics
            gameOptions.fullscreen = fullscreen;
            gameOptions.windowedBorderlessFullscreen = windowedBorderlessFullscreen;
            gameOptions.showMenuBackground = showMenuBackground;
            gameOptions.pinToolbarToggle = pinToolbarToggle;
            gameOptions.zoomButtons = zoomButtons;
            gameOptions.screenFlash = screenFlash;
            gameOptions.vsyncEnabled = vsyncEnabled;
            gameOptions.snowTransparency = snowTransparency;
            //gameOptions.zoomLevel = options.zoomLevel;
            gameOptions.localCoopBaseZoomLevel = localCoopBaseZoomLevel;
            //gameOptions.uiScale = options.uiScale;
            gameOptions.localCoopDesiredUIScale = localCoopDesiredUIScale;
            gameOptions.preferredResolutionX = preferredResolutionX;
            gameOptions.preferredResolutionY = preferredResolutionY;
            gameOptions.lightingQuality = lightingQuality;
            gameOptions.hardwareCursor = hardwareCursor;

            // controls
            gameOptions.mouseControls = mouseControls;
            gameOptions.keyboardControls = keyboardControls;
            gameOptions.gamepadControls = gamepadControls;
            gameOptions.rumble = rumble;
            gameOptions.invertScrollDirection = invertScrollDirection;
            gameOptions.stowingMode = stowingMode;
            gameOptions.gamepadMode = gamepadMode;
            gameOptions.actionButton = actionButton;
            gameOptions.cancelButton = cancelButton;
            gameOptions.useToolButton = useToolButton;
            gameOptions.moveUpButton = moveUpButton;
            gameOptions.moveRightButton = moveRightButton;
            gameOptions.moveDownButton = moveDownButton;
            gameOptions.moveLeftButton = moveLeftButton;
            gameOptions.menuButton = menuButton;
            gameOptions.runButton = runButton;
            gameOptions.tmpKeyToReplace = tmpKeyToReplace;
            gameOptions.chatButton = chatButton;
            gameOptions.mapButton = mapButton;
            gameOptions.journalButton = journalButton;
            gameOptions.inventorySlot1 = inventorySlot1;
            gameOptions.inventorySlot2 = inventorySlot2;
            gameOptions.inventorySlot3 = inventorySlot3;
            gameOptions.inventorySlot4 = inventorySlot4;
            gameOptions.inventorySlot5 = inventorySlot5;
            gameOptions.inventorySlot6 = inventorySlot6;
            gameOptions.inventorySlot7 = inventorySlot7;
            gameOptions.inventorySlot8 = inventorySlot8;
            gameOptions.inventorySlot9 = inventorySlot9;
            gameOptions.inventorySlot10 = inventorySlot10;
            gameOptions.inventorySlot11 = inventorySlot11;
            gameOptions.inventorySlot12 = inventorySlot12;
            gameOptions.toolbarSwap = toolbarSwap;
            gameOptions.emoteButton = emoteButton;
        }

        internal void SetFromGame()
        {
            StardewValley.Options gameOptions = Game1.options;

            // general
            autoRun = gameOptions.autoRun;
            showPortraits = gameOptions.showPortraits;
            showMerchantPortraits = gameOptions.showMerchantPortraits;
            alwaysShowToolHitLocation = gameOptions.alwaysShowToolHitLocation;
            hideToolHitLocationWhenInMotion = gameOptions.hideToolHitLocationWhenInMotion;
            pauseWhenOutOfFocus = gameOptions.pauseWhenOutOfFocus;
            showPlacementTileForGamepad = gameOptions.showPlacementTileForGamepad;
            snappyMenus = gameOptions.snappyMenus;
            ipConnectionsEnabled = gameOptions.ipConnectionsEnabled;
            enableServer = gameOptions.enableServer;
            enableFarmhandCreation = gameOptions.enableFarmhandCreation;
            showAdvancedCraftingInformation = gameOptions.showAdvancedCraftingInformation;
            showMPEndOfNightReadyStatus = gameOptions.showMPEndOfNightReadyStatus;
            useLegacySlingshotFiring = gameOptions.useLegacySlingshotFiring;

            // sounds
            dialogueTyping = gameOptions.dialogueTyping;
            playFootstepSounds = gameOptions.playFootstepSounds;
            ambientOnlyToggle = gameOptions.ambientOnlyToggle;
            muteAnimalSounds = gameOptions.muteAnimalSounds;
            musicVolumeLevel = gameOptions.musicVolumeLevel;
            soundVolumeLevel = gameOptions.soundVolumeLevel;
            footstepVolumeLevel = gameOptions.footstepVolumeLevel;
            ambientVolumeLevel = gameOptions.ambientVolumeLevel;

            // graphics
            fullscreen = gameOptions.fullscreen;
            windowedBorderlessFullscreen = gameOptions.windowedBorderlessFullscreen;
            showMenuBackground = gameOptions.showMenuBackground;
            pinToolbarToggle = gameOptions.pinToolbarToggle;
            zoomButtons = gameOptions.zoomButtons;
            screenFlash = gameOptions.screenFlash;
            vsyncEnabled = gameOptions.vsyncEnabled;
            snowTransparency = gameOptions.snowTransparency;
            zoomLevel = gameOptions.zoomLevel;
            localCoopBaseZoomLevel = gameOptions.localCoopBaseZoomLevel;
            uiScale = gameOptions.uiScale;
            localCoopDesiredUIScale = gameOptions.localCoopDesiredUIScale;
            preferredResolutionX = gameOptions.preferredResolutionX;
            preferredResolutionY = gameOptions.preferredResolutionY;
            lightingQuality = gameOptions.lightingQuality;
            hardwareCursor = gameOptions.hardwareCursor;

            // controls
            mouseControls = gameOptions.mouseControls;
            keyboardControls = gameOptions.keyboardControls;
            gamepadControls = gameOptions.gamepadControls;
            rumble = gameOptions.rumble;
            invertScrollDirection = gameOptions.invertScrollDirection;
            stowingMode = gameOptions.stowingMode;
            gamepadMode = gameOptions.gamepadMode;
            actionButton = gameOptions.actionButton;
            cancelButton = gameOptions.cancelButton;
            useToolButton = gameOptions.useToolButton;
            moveUpButton = gameOptions.moveUpButton;
            moveRightButton = gameOptions.moveRightButton;
            moveDownButton = gameOptions.moveDownButton;
            moveLeftButton = gameOptions.moveLeftButton;
            menuButton = gameOptions.menuButton;
            runButton = gameOptions.runButton;
            tmpKeyToReplace = gameOptions.tmpKeyToReplace;
            chatButton = gameOptions.chatButton;
            mapButton = gameOptions.mapButton;
            journalButton = gameOptions.journalButton;
            inventorySlot1 = gameOptions.inventorySlot1;
            inventorySlot2 = gameOptions.inventorySlot2;
            inventorySlot3 = gameOptions.inventorySlot3;
            inventorySlot4 = gameOptions.inventorySlot4;
            inventorySlot5 = gameOptions.inventorySlot5;
            inventorySlot6 = gameOptions.inventorySlot6;
            inventorySlot7 = gameOptions.inventorySlot7;
            inventorySlot8 = gameOptions.inventorySlot8;
            inventorySlot9 = gameOptions.inventorySlot9;
            inventorySlot10 = gameOptions.inventorySlot10;
            inventorySlot11 = gameOptions.inventorySlot11;
            inventorySlot12 = gameOptions.inventorySlot12;
            toolbarSwap = gameOptions.toolbarSwap;
            emoteButton = gameOptions.emoteButton;
        }

        // general
        public bool autoRun;
        public bool showPortraits;
        public bool showMerchantPortraits;
        public bool alwaysShowToolHitLocation;
        public bool hideToolHitLocationWhenInMotion;
        public bool pauseWhenOutOfFocus;
        public bool showPlacementTileForGamepad;
        public bool snappyMenus;
        public bool ipConnectionsEnabled;
        public bool enableServer;
        public bool enableFarmhandCreation;
        public bool showAdvancedCraftingInformation;
        public bool showMPEndOfNightReadyStatus;
        public bool useLegacySlingshotFiring;

        // sound
        public bool dialogueTyping;
        public bool playFootstepSounds;
        public bool ambientOnlyToggle;
        public bool muteAnimalSounds;
        public float musicVolumeLevel;
        public float soundVolumeLevel;
        public float footstepVolumeLevel;
        public float ambientVolumeLevel;

        // graphics
        public bool fullscreen;
        public bool windowedBorderlessFullscreen;
        public bool showMenuBackground;
        public bool pinToolbarToggle;
        public bool zoomButtons;
        public bool screenFlash;
        public bool vsyncEnabled;
        public float snowTransparency;
        public float zoomLevel;
        public float localCoopBaseZoomLevel;
        public float uiScale;
        public float localCoopDesiredUIScale;
        public int preferredResolutionX;
        public int preferredResolutionY;
        public int lightingQuality;
        public bool hardwareCursor;

        // controls
        public bool mouseControls;
        public bool keyboardControls;
        public bool gamepadControls;
        public bool rumble;
        public bool invertScrollDirection;
        public StardewValley.Options.ItemStowingModes stowingMode;
        public StardewValley.Options.GamepadModes gamepadMode;
        public InputButton[] actionButton;
        public InputButton[] cancelButton;
        public InputButton[] useToolButton;
        public InputButton[] moveUpButton;
        public InputButton[] moveRightButton;
        public InputButton[] moveDownButton;
        public InputButton[] moveLeftButton;
        public InputButton[] menuButton;
        public InputButton[] runButton;
        public InputButton[] tmpKeyToReplace;
        public InputButton[] chatButton;
        public InputButton[] mapButton;
        public InputButton[] journalButton;
        public InputButton[] inventorySlot1;
        public InputButton[] inventorySlot2;
        public InputButton[] inventorySlot3;
        public InputButton[] inventorySlot4;
        public InputButton[] inventorySlot5;
        public InputButton[] inventorySlot6;
        public InputButton[] inventorySlot7;
        public InputButton[] inventorySlot8;
        public InputButton[] inventorySlot9;
        public InputButton[] inventorySlot10;
        public InputButton[] inventorySlot11;
        public InputButton[] inventorySlot12;
        public InputButton[] toolbarSwap;
        public InputButton[] emoteButton;
    }
}
