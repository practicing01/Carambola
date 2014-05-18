function Module_Gameplay::Variables_Initialize(%this)
{

%this.Bool_Is_Playing=true;

%this.Script_Object_Input_Controller=0;

%this.Vector_2D_Camera_Size=Window_Carambola.getCameraSize();

%this.Vector_2D_Background_Grid_Size="1 1";

%this.Vector_2D_World_Limits=
%this.Vector_2D_Background_Grid_Size.X*%this.Vector_2D_Camera_Size.X
SPC
%this.Vector_2D_Background_Grid_Size.Y*%this.Vector_2D_Camera_Size.Y;

%this.Vector_2D_Floor_Tile_Size=Vector_2D_Vector_To_Camera_By_Resolution_Scale("16 16","800 480");

%this.SimSet_World_Tile_Slots=new SimSet();

for (%y=0;%y<%this.Vector_2D_World_Limits.Y;%y+=%this.Vector_2D_Floor_Tile_Size.Y)
{

for (%x=0;%x<%this.Vector_2D_World_Limits.X;%x+=%this.Vector_2D_Floor_Tile_Size.X)
{

%ScriptObject_Tile_Slot=new ScriptObject()
{

Vector_2D_Position=
(%x-%Vector_2D_Grid_Half_Offset.X)+(%this.Vector_2D_Floor_Tile_Size.X*0.5)
SPC
(%y-%Vector_2D_Grid_Half_Offset.Y)+(%this.Vector_2D_Floor_Tile_Size.Y*0.5);

};

%this.SimSet_World_Tile_Slots.add(%ScriptObject_Tile_Slot);

}

}

%this.Main_Menu_Schedule=0;

%this.Vector_2D_Projectile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Flame);

%this.Vector_2D_Arrow_Projectile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Arrow);

%this.Float_Projectile_Speed=10;

%this.Vector_2D_Explosion_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Explosion);

%this.Vector_2D_Explosion_0_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Explosion_0);

%this.Vector_2D_Explosion_Radius=%this.Vector_2D_Explosion_0_Size.X;

if (%this.Vector_2D_Explosion_0_Size.X<%this.Vector_2D_Explosion_0_Size.Y)
{

%this.Vector_2D_Explosion_Radius=%this.Vector_2D_Explosion_0_Size.Y;

}

%this.Module_ID_Map_Background=0;

%this.SimSet_Offender_Tiles=0;

%this.Schedule_Offenders_Spawn=0;

%this.Int_Offender_Max=200;

%this.Int_Offender_Count=0;

%this.Score=0;

%this.SimSet_Defender_Tiles=0;

%this.ScriptObject_Defender_Tile=0;

%this.Bool_Casting_Defender=false;

%this.Int_Casting_Interval=4;

%this.Int_Casting_Interval_Counter=0;

%this.Int_Defender_Max=10;//Per class.

%this.Int_Max_Targets=5;

%this.Bool_Can_Cast_Towers=true;

%this.Bool_Can_Cast_Defenders=true;

/*************************************************************************************/

}
