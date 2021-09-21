# J-Tools #
This is my personal code library that I use between projects. Most of it is just to save time really. Just though I'd make a packaged version to make it easier to transfer between projects and ley others use it if they wish. There is no documentation for this at this time, I do plan to add some, but it's pretty far down the to-do list. Most scripts are commented with the normal XML comments so that should help here and there. 

## How To Install ##
This repo is designed to be installed via the Package manager in Unity. Just go to Window/Package Manager, under the + option use "Add package via git URL". Then copy the text below into the field and click add. 

<pre>
https://github.com/JonathanMCarter/com.cartergames.tools.jtools.git
</pre>

That's it, that package will import and you should be all set to use the library. 
<br><br>
## What Is What?
Below are summaries for each script in the library and what they are intended usage is. 

## Editor Scripts
The scripts in the Editor folder & namespace are for editor scripting and are really there to help with writing custom editors:
<br><br>
<code>Button</code> - For adding buttons to custom editors.
<br>
<code>Label</code> - For adding labels to custom editors.
<br>
<code>Layout</code> - For setting layout groups in custom editors.
<br>
<code>Colours</code> - Just to help adding colour to custom editors. 

## Runtime Scripts
Contains all the scripts that can be used at runtime in your games.

### Attributes
<code>ReadOnly</code> - Makes an element a read-only field in the inspector, so you can view the field but not edit it. Use via: <code>[ReadOnly]</code>

### Get
<code>GetChance</code> - For getting changes like 1 in 100, 50/50 & 1 in X.
<br>
<code>GetDiceRoll</code> - For getting dice rolls for a D4, D6, D8, D10, D12 & D20.
<br>
<code>GetLowHigh</code> - For getting lowest, median & highest in int lists mostly.
<br>
<code>GetRandom</code> - For getting random values, like using <code>Random.Range</code> but just expanded a fair bit.
<br>
<code>GetVector</code> - For doing some vector math mostly.

### Helpers
<code>CanvasHelper</code> - Helper methods to do with Canvases & Canvas Groups.
<br>
<code>ColourHelper</code> - Helper methods to do with Colours.
<br>
<code>ListArrayHelper</code> - Helper methods for lists & arrays.
<br>
<code>PoolHelper</code> - Helper methods for creating and managing object pools.

### Interfaces
<code>IDamagable</code> - Basic interface for having a object be damagable.
<br>
<code>IDeepCopy</code> - Interface for getting deep copies of lists.
<br>
<code>IHealth</code> - Basic interface for having a object have health.
<br>
<code>IInteractable</code> - Basic interface for object interactions.
<br>
<code>IInvulnerable</code> - Basic interface for having a object be invulnerable.
<br>
<code>ISelectable</code> - Basic interface for having a object be selectable.
<br>

### Misc
These scripts don't easily fit into a category or is still a work in progress.<br><br>
<code>CursorController</code> - For having custom cursors in your games.
<br>
<code>DeepCopy</code> - For getting deep copies of any type.
<br>
<code>Despawner</code> - For despawning objects in a veriety of ways.
<br>
<code>GenericTimerDisplay</code> - For showing & managing a timer.
<br>
<code>GetGeneral</code> - For getting and editing values such as: difference between values, inverting values & normalising values. 
<br>
<code>JLogger</code> - Alternative for <code>Debug.Log</code> that can be disabled with a scripting define, the define is: <code>USE_JLOG</code>
<br>
<code>MinMax</code> - For defining a min/max ranges.
<br>
<code>MoneyFormat</code> - For formatting a double as generic currency.
<br>
<code>OpenURL</code> - For opening URL's, both webpages & discord invite links.
<br>
<code>PositionFormat</code> - For formatting int's as a position like 1st, 2nd, 3rd, 4th etc.
<br>
<code>ProgressBar</code> - For creating sliders with just UI images using a sliced image and a normalised value.
<br>
<code>TryGet</code> - A version of TryGetComponent but for parents and children of an GameObject.
<br>

### Polish
<code>CameraShake</code> - For shaking the camera around a bit.
<br>

### Raycasting
<code>Raycast</code> - For calling raycasts that I know actually work xD
<br>

### Render Textures
<code>RenderTextureCameraDisable</code> - For disabling cameras that are used to create render textures.
<br>
<code>RenderTextureManager</code> - For managing the creation of render textures.
<br>

### Scene
<code>FrameLimiter</code> - For limiting the number of <code>Update()</code> frames the code under it runs.
<br>
<code>SceneElly</code> - For getting components in the active scene, an additive scene or all active scenes.
<br>

### Scriptable Objects
<code>ColorCollection</code> - For holding a list of colours with options for basic colour blindness support.
<br>
<code>IntCollection</code> - For holding a list of ints.
<br>
<code>SpriteCollection</code> - For holding a list of sprites.
<br>
<code>StringCollection</code> - For holding a list of strings.
<br>

### Transform
<code>RandomMovement</code> - For randomly moving objects by x amount.
<br>
<code>RandomRotation</code> - For randomly rotating objects by x amount.
<br>
<code>RotateScript</code> - For rotating an object on XYZ in any combination at a defined speed.
<br>

### UI
<code>CustomGridLayout</code> - A custom version of the <code>GridLayout</code> component. 
<br>















