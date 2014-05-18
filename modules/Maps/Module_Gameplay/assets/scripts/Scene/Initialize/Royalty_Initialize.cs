function Module_Gameplay::Royalty_Initialize(%this)
{

%Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_King);

%Sprite_Defender=new Sprite()
{

Position=(%this.Vector_2D_World_Limits.X*0.5)-(%Tile_Size.X*0.5) SPC %Tile_Size.Y*0.5;
Size=%Tile_Size;
Animation="Module_Gameplay:Animation_King_Run_Up";
class="Class_King";
CollisionCallback="true";
SceneLayer=16;

BodyType="static";

FixedAngle=true;

GravityScale=0;

SceneGroup=1;//Defenders.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Int_Health=100;

Int_Attack=10;

SimSet_Targets=0;

Animation_Run="Module_Gameplay:Animation_King_Run";

Animation_Attack="Module_Gameplay:Animation_King_Attack";

Animation_Cast="Module_Gameplay:Animation_King_Cast";

Animation_Run_Up="Module_Gameplay:Animation_King_Run_Up";

Animation_Attack_Up="Module_Gameplay:Animation_King_Attack_Up";

Animation_Cast_Up="Module_Gameplay:Animation_King_Cast_Up";

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

Schedule_AI=0;

};

%Sprite_Defender.SimSet_Targets=new SimSet();

%Sprite_Defender.setCollisionGroups(0,1,2,3,4,30);//Towers, Defenders, Offenders, Collidable Defender Sensors, Collidable Offender Sensors, Walls

%Radius=%Tile_Size.X;

if (%Tile_Size.X<%Tile_Size.Y)
{

%Radius=%Tile_Size.Y;

}

%Sprite_Defender.Collision_Shape_Index=%Sprite_Defender.createCircleCollisionShape(%Radius);

Scene_Carambola.add(%Sprite_Defender);

%Sprite_Defender.Initialize();

/**************************************************************************/

%Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Queen);

%Sprite_Defender=new Sprite()
{

Position=(%this.Vector_2D_World_Limits.X*0.5)+(%Tile_Size.X*0.5) SPC %Tile_Size.Y*0.5;
Size=%Tile_Size;
Animation="Module_Gameplay:Animation_Queen_Run_Up";
class="Class_Queen";
CollisionCallback="true";
SceneLayer=16;

BodyType="static";

FixedAngle=true;

GravityScale=0;

SceneGroup=1;//Defenders.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Int_Health=100;

Int_Attack=10;

SimSet_Targets=0;

Animation_Run="Module_Gameplay:Animation_Queen_Run";

Animation_Attack="Module_Gameplay:Animation_Queen_Attack";

Animation_Cast="Module_Gameplay:Animation_Queen_Cast";

Animation_Run_Up="Module_Gameplay:Animation_Queen_Run_Up";

Animation_Attack_Up="Module_Gameplay:Animation_Queen_Attack_Up";

Animation_Cast_Up="Module_Gameplay:Animation_Queen_Cast_Up";

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

Schedule_AI=0;

};

%Sprite_Defender.SimSet_Targets=new SimSet();

%Sprite_Defender.setCollisionGroups(0,1,2,3,4,30);//Towers, Defenders, Offenders, Collidable Defender Sensors, Collidable Offender Sensors, Walls

%Radius=%Tile_Size.X;

if (%Tile_Size.X<%Tile_Size.Y)
{

%Radius=%Tile_Size.Y;

}

%Sprite_Defender.Collision_Shape_Index=%Sprite_Defender.createCircleCollisionShape(%Radius);

Scene_Carambola.add(%Sprite_Defender);

%Sprite_Defender.Initialize();

}
