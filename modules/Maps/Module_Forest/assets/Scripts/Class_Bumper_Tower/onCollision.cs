function Class_Bumper_Tower::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==2||%Colliding_Object.SceneGroup==4)//Offenders
{

//%Colliding_Object.Update_Health(%this.Int_Attack,-1);

}

%Float_Angle=Vector2AngleToPoint(%this.Position,%Colliding_Object.Position);

%Colliding_Object.setLinearVelocityPolar(%Float_Angle,100);

}
