function Module_Forest::Generate_Gui_Towers(%this)
{

/********************************************************************************************************************/

//Static Tower Button

%ScriptObject_String_Tile=%this.SimSet_String_Static_Tower_Tiles.getObject(getRandom(0,%this.SimSet_String_Static_Tower_Tiles.getCount()-1));

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Towers_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("768 84","800 480",Carambola.Resolution);

Profile="GreenButtonProfile";

Module_ID_Parent=%this;

String_Tower_Type="Static";

};

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Image=%ScriptObject_String_Tile.String_Name;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

/********************************************************************************************************************/

//Slapper Tower Button

%ScriptObject_String_Tile=%this.SimSet_String_Slapper_Tower_Tiles.getObject(getRandom(0,%this.SimSet_String_Slapper_Tower_Tiles.getCount()-1));

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Towers_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("768 116","800 480",Carambola.Resolution);

Profile="GreenButtonProfile";

Module_ID_Parent=%this;

String_Tower_Type="Slapper";

};

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Image=%ScriptObject_String_Tile.String_Name;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

/********************************************************************************************************************/

//Bumper Tower Button

%ScriptObject_String_Tile=%this.SimSet_String_Bumper_Tower_Tiles.getObject(getRandom(0,%this.SimSet_String_Bumper_Tower_Tiles.getCount()-1));

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Towers_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("768 148","800 480",Carambola.Resolution);

Profile="GreenButtonProfile";

Module_ID_Parent=%this;

String_Tower_Type="Bumper";

};

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Image=%ScriptObject_String_Tile.String_Name;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

/********************************************************************************************************************/

}
