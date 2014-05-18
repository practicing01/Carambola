function Module_Gameplay::Cast_Defenders(%this,%Vector_2D_World_Position)
{

if (!%this.Bool_Can_Cast_Defenders){return;}

if (%this.ScriptObject_Defender_Tile.GuiButtonCtrl.Int_Defender_Count>%this.Int_Defender_Max)
{

return;

}
else
{

%this.ScriptObject_Defender_Tile.GuiButtonCtrl.Int_Defender_Count++;

}

%Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.ScriptObject_Defender_Tile.Ass_Image);

%Sprite_Defender=new Sprite()
{

Position=%Vector_2D_World_Position;
Size=%Tile_Size;
Animation=%this.ScriptObject_Defender_Tile.String_Animation_Run_Up;
class=%this.ScriptObject_Defender_Tile.String_Class;
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

Animation_Run=%this.ScriptObject_Defender_Tile.String_Animation_Run;

Animation_Attack=%this.ScriptObject_Defender_Tile.String_Animation_Attack;

Animation_Cast=%this.ScriptObject_Defender_Tile.String_Animation_Cast;

Animation_Run_Up=%this.ScriptObject_Defender_Tile.String_Animation_Run_Up;

Animation_Attack_Up=%this.ScriptObject_Defender_Tile.String_Animation_Attack_Up;

Animation_Cast_Up=%this.ScriptObject_Defender_Tile.String_Animation_Cast_Up;

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

GuiButtonCtrl_Parent=%this.ScriptObject_Defender_Tile.GuiButtonCtrl;

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
