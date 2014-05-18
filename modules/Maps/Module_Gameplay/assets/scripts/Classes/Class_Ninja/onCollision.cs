function Class_Ninja::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==2||%Colliding_Object.SceneGroup==4)//Offenders
{

%this.Bool_Targetable=true;

%this.BlendColor="1 1 1 1";

%this.Animation=%this.Animation_Attack_Up;

%Vector_2D_Position=getRandomF(%this.Size.X*0.5,%this.Module_ID_Parent.Vector_2D_World_Limits.X-(%this.Size.X*0.5))
SPC
(%this.Module_ID_Parent.Vector_2D_World_Limits.Y*0.5)-(%this.Size.Y*0.5);

%this.Position=%Vector_2D_Position;

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

}
