# NeoFPS - Highlight Plus
NeoFPS and Highlight Plus integration and demo. See a [video of it in action](https://streamable.com/bqsbq)

## Requirements
This repository was created using Unity 2017.4

It requires the assets [NeoFPS](https://assetstore.unity.com/packages/templates/systems/neofps-150179?aid=1011l58Ft) and [Highlight Plus](https://assetstore.unity.com/packages/tools/particles-effects/highlight-plus-134149?aid=1011l58Ft).

## Installation And Use
Simply import Highlight Plus into a NeoFPS project and grab the **InteractiveObjectHighlightPlus** script from this repository.

> [!WARNING]
> Do not place the integration folder or the script file inside the NeoFPS asset folder structure. If you do this then the script will be picked up by the NeoFPS assembly definition, which will limit what other scripts within the project it has access to. For more information on assembly definitions, see [the Unity Manual](https://docs.unity3d.com/Manual/ScriptCompilationAssemblyDefinitionFiles.html).

Highlighting an object requires 3 steps. Firstly, you need to add the **Highlight Effect** component to the geometry object that you want to highlight. Next, add the **InteractiveObjectHighlightPlus** component to the object with the **InteractiveObject** component or a component that inherits from it (such as the multi-item pickup). Lastly, drag the **Highlight Effect** component onto the property in the **InteractiveObjectHighlightPlus** and that's it.
	
#### Demo Scene
The demo scene is a simple scene with a few of the demo prefabs from the NeoFPS feature demos adapted to use Highlight Plus highlighting.

#### Prefabs
The demo folder contains the following demo prefabs:
- **HighlightPlus_HingeDoor** is a version of the animated hinge door from the NeoFPS demos with Highlight Plus highlighting
- **HighlightPlus_AmmoCrate** is an updated version of the ammo crate
- **HighlightPlus_AssaultRiflePickup** is an updated version of the assault rifle pickup. The contact ammo pickup has been disabled for demo purposes.
- **HighlightPlus_AssaultRifle** is a version of the modular assault rifle which has been modified to drop the pickup above.
