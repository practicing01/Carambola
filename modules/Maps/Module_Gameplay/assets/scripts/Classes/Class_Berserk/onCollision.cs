function Class_Berserk::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==2||%Colliding_Object.SceneGroup==4)//Offenders
{

%this.Animation=%this.Animation_Attack_Up;

if (!%this.Bool_Blind)
{

%Colliding_Object.Update_Health(%this.Int_Attack,-1);

%Float_Angle=Vector2AngleToPoint(%this.Position,%Colliding_Object.Position);

%Colliding_Object.setLinearVelocityPolar(%Float_Angle,100);

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
