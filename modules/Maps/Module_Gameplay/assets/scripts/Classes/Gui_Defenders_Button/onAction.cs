function Gui_Defenders_Button::onAction(%this)
{

%this.Module_ID_Parent.Module_ID_Map_Background.Bool_Casting_Tower=false;

%this.Module_ID_Parent.Bool_Casting_Defender=true;

if (getRandom(0,1))
{

%this.Module_ID_Parent.ScriptObject_Defender_Tile=%this.ScriptObject_Defender_Tile;

}
else
{

%this.Module_ID_Parent.ScriptObject_Defender_Tile=%this.ScriptObject_Defender_Tile_F;

}

}
