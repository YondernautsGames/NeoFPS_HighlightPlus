# NeoFPS - Highlight Plus
NeoFPS and Highlight Plus integration and demo

## Requirements
This repository was created using Unity 2017.4

It requires the assets [NeoFPS](https://assetstore.unity.com/packages/templates/systems/neofps-150179?aid=1011l58Ft) and [Highlight Plus](https://assetstore.unity.com/packages/tools/particles-effects/highlight-plus-134149?aid=1011l58Ft).

## Installation And Use
Simply import Highlight Plus into a NeoFPS project and grab the **InteractiveObjectHighlightPlus** script from this repository.

Highlighting an object requires 3 steps. Firstly, you need to add the **Highlight Effect** component to the geometry objects (the objects with a mesh renderer) on the interactive object. You can add multiple highlight effects to different geometry objects if required. For example, in the demo, the door also has the effect added to the handle. After this, add the **InteractiveObjectHighlightPlus** component to the object with the **InteractiveObject** component or a component that inherits from it (such as the multi item pickup). Drag each **Highlight Effect** component onto the property in the **InteractiveObjectHighlightPlus** and that's it.
	
#### Demo Scene
The demo scene is a simple scene with a few of the demo prefabs from the NeoFPS feature demos adapted to use Highlight Plus highlighting.

#### Prefabs
The demo folder contains the following demo prefabs:
- **HighlightPlus_HingeDoor** is a version of the animated hinge door from the NeoFPS demos with Highlight Plus highlighting
- **HighlightPlus_AmmoCrate** is an updated version of the ammo crate
- **HighlightPlus_AssaultRiflePickup** is an updated version of the assault rifle pickup. The contact ammo pickup has been disabled for demo purposes.
- **HighlightPlus_AssaultRifle** is a version of the modular assault rifle which has been modified to drop the pickup above.

## Issues
When adding the effects to a hierarchy of objects, it is best to add each effect to the **InteractiveObjectHighlightPlus** instead of relying on Highlight Plus' highlight children system. The latter does not seem to correctly un-highlight children once the parent is unhighlighted.