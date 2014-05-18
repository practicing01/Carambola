function Module_Gameplay::Offenders_Spawn(%this)
{

for (%x=0;%x<10;%x++)
{

%ScriptObject_Offender_Tile=%this.SimSet_Offender_Tiles.getObject(getRandom(0,%this.SimSet_Offender_Tiles.getCount()-1));

%Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%ScriptObject_Offender_Tile.Ass_Image);

%Vector_2D_Position=getRandomF(%Tile_Size.X*0.5,%this.Vector_2D_World_Limits.X-(%Tile_Size.X*0.5))
SPC
%this.Vector_2D_World_Limits.Y-(%Tile_Size.Y*0.5);

%Sprite_Offender=new Sprite()
{

Position=%Vector_2D_Position;
Size=%Tile_Size;
//Image=%ScriptObject_Offender_Tile.String_Name;
Animation=%ScriptObject_Offender_Tile.String_Animation_Run;
class=%ScriptObject_Offender_Tile.String_Class;
CollisionCallback="true";
SceneLayer=16;

FixedAngle=true;

SceneGroup=2;//Offenders.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Int_Health=100;

Int_Attack=10;

SimSet_Targets=0;

Animation_Run=%ScriptObject_Offender_Tile.String_Animation_Run;

Animation_Attack=%ScriptObject_Offender_Tile.String_Animation_Attack;

Animation_Cast=%ScriptObject_Offender_Tile.String_Animation_Cast;

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

};

%Sprite_Offender.SimSet_Targets=new SimSet();

%Sprite_Offender.setCollisionGroups(0,1,2,3,4,30);//Towers, Defenders, Offenders, Collidable Defender Sensors, Collidable Offender Sensors, Walls

%Radius=%Tile_Size.X;

if (%Tile_Size.X<%Tile_Size.Y)
{

%Radius=%Tile_Size.Y;

}

%Sprite_Offender.Collision_Shape_Index=%Sprite_Offender.createCircleCollisionShape(%Radius);

Scene_Carambola.add(%Sprite_Offender);

%Sprite_Offender.Initialize();

%this.Int_Offender_Count++;

if (%this.Int_Offender_Count>=%this.Int_Offender_Max)
{

schedule(1000,0,"Gui_Gameplay::Go_Main_Menu");

return;

}

}

%this.Schedule_Offenders_Spawn=schedule(5000,0,"Module_Gameplay::Offenders_Spawn",%this);

}

function Module_Gameplay::Offenders_Initialize(%this)
{

%this.SimSet_Offender_Tiles=new SimSet();

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Cultist";

String_Animation_Run="Module_Gameplay:Animation_Cultist_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Cultist_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Cultist_Cast_Down";

Ass_Image=%this.Ass_Image_Cultist;

String_Class="Class_Cultist";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Dark_Elemental";

String_Animation_Run="Module_Gameplay:Animation_Dark_Elemental_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Dark_Elemental_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Dark_Elemental_Cast_Down";

Ass_Image=%this.Ass_Image_Dark_Elemental;

String_Class="Class_Dark_Elemental";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Dark_Knight";

String_Animation_Run="Module_Gameplay:Animation_Dark_Knight_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Dark_Knight_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Dark_Knight_Cast_Down";

Ass_Image=%this.Ass_Image_Dark_Knight;

String_Class="Class_Dark_Knight";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Dark_Knight_F";

String_Animation_Run="Module_Gameplay:Animation_Dark_Knight_F_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Dark_Knight_F_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Dark_Knight_F_Cast_Down";

Ass_Image=%this.Ass_Image_Dark_Knight_F;

String_Class="Class_Dark_Knight";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Earth_Elemental";

String_Animation_Run="Module_Gameplay:Animation_Earth_Elemental_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Earth_Elemental_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Earth_Elemental_Cast_Down";

Ass_Image=%this.Ass_Image_Earth_Elemental;

String_Class="Class_Earth_Elemental";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Fire_Elemental";

String_Animation_Run="Module_Gameplay:Animation_Fire_Elemental_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Fire_Elemental_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Fire_Elemental_Cast_Down";

Ass_Image=%this.Ass_Image_Fire_Elemental;

String_Class="Class_Fire_Elemental";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Flying_Skull";

String_Animation_Run="Module_Gameplay:Animation_Flying_Skull_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Flying_Skull_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Flying_Skull_Cast_Down";

Ass_Image=%this.Ass_Image_Flying_Skull;

String_Class="Class_Flying_Skull";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Frank";

String_Animation_Run="Module_Gameplay:Animation_Frank_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Frank_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Frank_Cast_Down";

Ass_Image=%this.Ass_Image_Frank;

String_Class="Class_Frank";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Goblin";

String_Animation_Run="Module_Gameplay:Animation_Goblin_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Goblin_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Goblin_Cast_Down";

Ass_Image=%this.Ass_Image_Goblin;

String_Class="Class_Goblin";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Jelly";

String_Animation_Run="Module_Gameplay:Animation_Jelly_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Jelly_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Jelly_Cast_Down";

Ass_Image=%this.Ass_Image_Jelly;

String_Class="Class_Jelly";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Light_Elemental";

String_Animation_Run="Module_Gameplay:Animation_Light_Elemental_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Light_Elemental_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Light_Elemental_Cast_Down";

Ass_Image=%this.Ass_Image_Light_Elemental;

String_Class="Class_Light_Elemental";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Mummy";

String_Animation_Run="Module_Gameplay:Animation_Mummy_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Mummy_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Mummy_Cast_Down";

Ass_Image=%this.Ass_Image_Mummy;

String_Class="Class_Mummy";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Mushroom";

String_Animation_Run="Module_Gameplay:Animation_Mushroom_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Mushroom_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Mushroom_Cast_Down";

Ass_Image=%this.Ass_Image_Mushroom;

String_Class="Class_Mushroom";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Orc";

String_Animation_Run="Module_Gameplay:Animation_Orc_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Orc_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Orc_Cast_Down";

Ass_Image=%this.Ass_Image_Orc;

String_Class="Class_Orc";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Rat";

String_Animation_Run="Module_Gameplay:Animation_Rat_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Rat_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Rat_Cast_Down";

Ass_Image=%this.Ass_Image_Rat;

String_Class="Class_Rat";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Rat_King";

String_Animation_Run="Module_Gameplay:Animation_Rat_King_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Rat_King_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Rat_King_Cast_Down";

Ass_Image=%this.Ass_Image_Rat_King;

String_Class="Class_Rat_King";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Rock_Golem";

String_Animation_Run="Module_Gameplay:Animation_Rock_Golem_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Rock_Golem_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Rock_Golem_Cast_Down";

Ass_Image=%this.Ass_Image_Rock_Golem;

String_Class="Class_Rock_Golem";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Skeleton";

String_Animation_Run="Module_Gameplay:Animation_Skeleton_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Skeleton_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Skeleton_Cast_Down";

Ass_Image=%this.Ass_Image_Skeleton;

String_Class="Class_Skeleton";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Swamp_Creature";

String_Animation_Run="Module_Gameplay:Animation_Swamp_Creature_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Swamp_Creature_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Swamp_Creature_Cast_Down";

Ass_Image=%this.Ass_Image_Swamp_Creature;

String_Class="Class_Swamp_Creature";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

%ScriptObject_Offender_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Vampire";

String_Animation_Run="Module_Gameplay:Animation_Vampire_Run_Down";

String_Animation_Attack="Module_Gameplay:Animation_Vampire_Attack_Down";

String_Animation_Cast="Module_Gameplay:Animation_Vampire_Cast_Down";

Ass_Image=%this.Ass_Image_Vampire;

String_Class="Class_Vampire";

};

%this.SimSet_Offender_Tiles.add(%ScriptObject_Offender_Tile);

/*******************************************************************************/

schedule(60000,0,"Module_Gameplay::Offenders_Spawn",%this);

}
