function Module_Gameplay::Defenders_Initialize(%this)
{

%this.SimSet_Defender_Tiles=new SimSet();

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Angel";

String_Animation_Run="Module_Gameplay:Animation_Angel_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Angel_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Angel_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Angel_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Angel_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Angel_Cast_Up";

Ass_Image=%this.Ass_Image_Angel;

String_Class="Class_Angel";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 0","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Angel_F";

String_Animation_Run="Module_Gameplay:Animation_Angel_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Angel_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Angel_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Angel_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Angel_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Angel_F_Cast_Up";

Ass_Image=%this.Ass_Image_Angel_F;

String_Class="Class_Angel";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Bard";

String_Animation_Run="Module_Gameplay:Animation_Bard_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Bard_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Bard_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Bard_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Bard_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Bard_Cast_Up";

Ass_Image=%this.Ass_Image_Bard;

String_Class="Class_Bard";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 32","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Berserk";

String_Animation_Run="Module_Gameplay:Animation_Berserk_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Berserk_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Berserk_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Berserk_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Berserk_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Berserk_Cast_Up";

Ass_Image=%this.Ass_Image_Berserk;

String_Class="Class_Berserk";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 64","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Berserk_F";

String_Animation_Run="Module_Gameplay:Animation_Berserk_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Berserk_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Berserk_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Berserk_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Berserk_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Berserk_F_Cast_Up";

Ass_Image=%this.Ass_Image_Berserk_F;

String_Class="Class_Berserk";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Mage";

String_Animation_Run="Module_Gameplay:Animation_Mage_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Mage_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Mage_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Mage_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Mage_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Mage_Cast_Up";

Ass_Image=%this.Ass_Image_Mage;

String_Class="Class_Mage";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 96","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Mage_F";

String_Animation_Run="Module_Gameplay:Animation_Mage_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Mage_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Mage_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Mage_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Mage_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Mage_F_Cast_Up";

Ass_Image=%this.Ass_Image_Mage_F;

String_Class="Class_Mage";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Monk";

String_Animation_Run="Module_Gameplay:Animation_Monk_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Monk_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Monk_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Monk_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Monk_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Monk_Cast_Up";

Ass_Image=%this.Ass_Image_Monk;

String_Class="Class_Monk";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 128","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Monk_F";

String_Animation_Run="Module_Gameplay:Animation_Monk_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Monk_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Monk_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Monk_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Monk_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Monk_F_Cast_Up";

Ass_Image=%this.Ass_Image_Monk_F;

String_Class="Class_Monk";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Ninja";

String_Animation_Run="Module_Gameplay:Animation_Ninja_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Ninja_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Ninja_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Ninja_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Ninja_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Ninja_Cast_Up";

Ass_Image=%this.Ass_Image_Ninja;

String_Class="Class_Ninja";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 160","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Ninja_F";

String_Animation_Run="Module_Gameplay:Animation_Ninja_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Ninja_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Ninja_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Ninja_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Ninja_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Ninja_F_Cast_Up";

Ass_Image=%this.Ass_Image_Ninja_F;

String_Class="Class_Ninja";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Paladin";

String_Animation_Run="Module_Gameplay:Animation_Paladin_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Paladin_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Paladin_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Paladin_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Paladin_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Paladin_Cast_Up";

Ass_Image=%this.Ass_Image_Paladin;

String_Class="Class_Paladin";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 192","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Ranger";

String_Animation_Run="Module_Gameplay:Animation_Ranger_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Ranger_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Ranger_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Ranger_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Ranger_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Ranger_Cast_Up";

Ass_Image=%this.Ass_Image_Ranger;

String_Class="Class_Ranger";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 224","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Ranger_F";

String_Animation_Run="Module_Gameplay:Animation_Ranger_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Ranger_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Ranger_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Ranger_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Ranger_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Ranger_F_Cast_Up";

Ass_Image=%this.Ass_Image_Ranger_F;

String_Class="Class_Ranger";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Samurai";

String_Animation_Run="Module_Gameplay:Animation_Samurai_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Samurai_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Samurai_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Samurai_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Samurai_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Samurai_Cast_Up";

Ass_Image=%this.Ass_Image_Samurai;

String_Class="Class_Samurai";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 256","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Samurai_F";

String_Animation_Run="Module_Gameplay:Animation_Samurai_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Samurai_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Samurai_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Samurai_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Samurai_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Samurai_F_Cast_Up";

Ass_Image=%this.Ass_Image_Samurai_F;

String_Class="Class_Samurai";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Soldier";

String_Animation_Run="Module_Gameplay:Animation_Soldier_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Soldier_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Soldier_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Soldier_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Soldier_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Soldier_Cast_Up";

Ass_Image=%this.Ass_Image_Soldier;

String_Class="Class_Soldier";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 288","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Soldier_F";

String_Animation_Run="Module_Gameplay:Animation_Soldier_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Soldier_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Soldier_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Soldier_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Soldier_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Soldier_F_Cast_Up";

Ass_Image=%this.Ass_Image_Soldier_F;

String_Class="Class_Soldier";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Warrior";

String_Animation_Run="Module_Gameplay:Animation_Warrior_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Warrior_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Warrior_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Warrior_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Warrior_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Warrior_Cast_Up";

Ass_Image=%this.Ass_Image_Warrior;

String_Class="Class_Warrior";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 320","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Warrior_F";

String_Animation_Run="Module_Gameplay:Animation_Warrior_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Warrior_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Warrior_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_Warrior_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_Warrior_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_Warrior_F_Cast_Up";

Ass_Image=%this.Ass_Image_Warrior_F;

String_Class="Class_Warrior";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_White_Mage";

String_Animation_Run="Module_Gameplay:Animation_White_Mage_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_White_Mage_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_White_Mage_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_White_Mage_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_White_Mage_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_White_Mage_Cast_Up";

Ass_Image=%this.Ass_Image_White_Mage;

String_Class="Class_White_Mage";

GuiButtonCtrl=0;

};

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

//////////////////////////////////

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Gui_Defenders_Button";

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 352","800 480",Carambola.Resolution);

Profile="BlueButtonProfile";

Module_ID_Parent=%this;

ScriptObject_Defender_Tile=%ScriptObject_Defender_Tile;

ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

Int_Defender_Count=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="32 32";

Position="0 0";

Profile="gui_profile_modalless";

Animation=%ScriptObject_Defender_Tile.String_Animation_Run;

Module_ID_Parent=%this;

};

%GuiButtonCtrl.addGuiControl(%GuiSpriteCtrl);

Gui_Carambola_Overlay.addGuiControl(%GuiButtonCtrl);

////////////////////////////////////////////////////

/*******************************************************************************/

%ScriptObject_Defender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_White_Mage_F";

String_Animation_Run="Module_Gameplay:Animation_White_Mage_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_White_Mage_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_White_Mage_F_Cast_Down";

String_Animation_Run_Up="Module_Gameplay:Animation_White_Mage_F_Run_Up";

String_Animation_Attack_Up="Module_Gameplay:Animation_White_Mage_F_Attack_Up";

String_Animation_Cast_Up="Module_Gameplay:Animation_White_Mage_F_Cast_Up";

Ass_Image=%this.Ass_Image_White_Mage_F;

String_Class="Class_White_Mage";

GuiButtonCtrl=0;

};

%ScriptObject_Defender_Tile.GuiButtonCtrl=%GuiButtonCtrl;

%this.SimSet_Defender_Tiles.add(%ScriptObject_Defender_Tile);

%GuiButtonCtrl.ScriptObject_Defender_Tile_F=%ScriptObject_Defender_Tile;

/*******************************************************************************/

}
