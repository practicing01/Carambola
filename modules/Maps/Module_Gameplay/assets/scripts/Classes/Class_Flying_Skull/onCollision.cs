function Class_Flying_Skull::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==0||%Colliding_Object.SceneGroup==1||%Colliding_Object.SceneGroup==3)//Towers, Defenders
{

//%this.Animation=%this.Animation_Attack;

if (!%this.Bool_Blind)
{

%Colliding_Object.Update_Health(%this.Int_Attack,-1);

}

/*if (%Colliding_Object.Bool_Targetable)
{

if (!%this.SimSet_Targets.isMember(%Colliding_Object))
{

%this.SimSet_Targets.add(%Colliding_Object);

}

}*/

}
else if (%Colliding_Object.SceneGroup==30)
{

//The following hack is necessary because with non-square sizes, distance checks from origins will be unusable

if (%Colliding_Object.String_Hack_Name$="Top")
{

%this.Vector_2D_Direction.Y=-1;

%this.Animation="Module_Gameplay:Animation_Flying_Skull_Run_Down";

}
else if (%Colliding_Object.String_Hack_Name$="Bottom")
{

%this.Vector_2D_Direction.Y=1;

%this.Animation="Module_Gameplay:Animation_Flying_Skull_Run_Up";

}
else if (%Colliding_Object.String_Hack_Name$="Left")
{

%this.Vector_2D_Direction.X=1;

%this.Animation="Module_Gameplay:Animation_Flying_Skull_Run_Right";

}
else if (%Colliding_Object.String_Hack_Name$="Right")
{

%this.Vector_2D_Direction.X=-1;

%this.Animation="Module_Gameplay:Animation_Flying_Skull_Run_Left";

}

if (%this.Vector_2D_Direction.X==1&&%this.Vector_2D_Direction.Y==1)
{

%this.setLinearVelocityPolar(45,%this.Int_Speed);

}
else if (%this.Vector_2D_Direction.X==-1&&%this.Vector_2D_Direction.Y==1)
{

%this.setLinearVelocityPolar(135,%this.Int_Speed);

}
else if (%this.Vector_2D_Direction.X==1&&%this.Vector_2D_Direction.Y==-1)
{

%this.setLinearVelocityPolar(-45,%this.Int_Speed);

}
else if (%this.Vector_2D_Direction.X==-1&&%this.Vector_2D_Direction.Y==-1)
{

%this.setLinearVelocityPolar(-135,%this.Int_Speed);

}

}

}
