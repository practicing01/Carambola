function Class_Rat_King::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==0||%Colliding_Object.SceneGroup==1||%Colliding_Object.SceneGroup==3)//Towers, Defenders
{

//%this.Animation=%this.Animation_Attack;

if (!%this.Bool_Blind)
{

%Colliding_Object.Update_Health(%this.Int_Attack,-1);

/**************************************************/

%Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Module_ID_Parent.Ass_Image_Rat);

%Sprite_Offender=new Sprite()
{

Position=%this.Position;
Size=%Tile_Size;
Animation="Module_Gameplay:Animation_Rat_Run_Down";
class="Class_Rat";
CollisionCallback="true";
SceneLayer=16;

FixedAngle=true;

SceneGroup=2;//Offenders.

Module_ID_Parent=%this.Module_ID_Parent;

Collision_Shape_Index=-1;

Int_Health=100;

Int_Attack=10;

SimSet_Targets=0;

Animation_Run="Module_Gameplay:Animation_Rat_Run_Down";

Animation_Attack="Module_Gameplay:Animation_Rat_Attack_Down";

Animation_Cast="Module_Gameplay:Animation_Rat_Cast_Down";

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

};

%Sprite_Offender.SimSet_Targets=new SimSet();

%Sprite_Offender.setCollisionGroups(0,1,2,30);//Towers, Defenders, Offenders, Walls

%Radius=%Tile_Size.X;

if (%Tile_Size.X<%Tile_Size.Y)
{

%Radius=%Tile_Size.Y;

}

%Sprite_Offender.Collision_Shape_Index=%Sprite_Offender.createCircleCollisionShape(%Radius);

Scene_Carambola.add(%Sprite_Offender);

%Sprite_Offender.Initialize();

%this.Module_ID_Parent.Int_Offender_Count++;

/**************************************************/

}

/*if (%Colliding_Object.Bool_Targetable)
{

if (!%this.SimSet_Targets.isMember(%Colliding_Object))
{

%this.SimSet_Targets.add(%Colliding_Object);

}

}*/

}

}
