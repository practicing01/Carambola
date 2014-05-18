function Class_Monk::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==2||%Colliding_Object.SceneGroup==4)//Offenders
{

%this.Animation=%this.Animation_Attack_Up;

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
