function Module_Gameplay::Scene_Unload(%this)
{

cancel(%this.Schedule_Offenders_Spawn);

%this.SimSet_Offender_Tiles.deleteObjects();

%this.SimSet_Offender_Tiles.delete();

%this.SimSet_Defender_Tiles.deleteObjects();

%this.SimSet_Defender_Tiles.delete();

if (isObject(%this.Gui_Text_Score))
{

%this.Gui_Text_Score.delete();

}

%this.SimSet_World_Tile_Slots.deleteObjects();

%this.SimSet_World_Tile_Slots.delete();

if (isObject(Window_Carambola)&&isObject(%this.Script_Object_Input_Controller))
{

Window_Carambola.removeInputListener(%this.Script_Object_Input_Controller);

}

%this.Bool_Is_Playing=false;

if (isObject(Gui_Gameplay))
{

Canvas.popDialog(Gui_Gameplay);

}

if (isObject(Gui_Carambola_Overlay))
{

Gui_Carambola_Overlay.deleteObjects();

}

%this.Ass_Unload();

}
