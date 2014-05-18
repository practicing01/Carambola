function Gui_Towers_Button::onAction(%this)
{

Module_Gameplay.Bool_Casting_Defender=false;

%this.Module_ID_Parent.Bool_Casting_Tower=true;

%this.Module_ID_Parent.String_Casting_Tower_Type=%this.String_Tower_Type;

}
