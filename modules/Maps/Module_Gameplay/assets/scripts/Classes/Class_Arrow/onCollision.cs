function Class_Arrow::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Skeleton"){return;}

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup!=30)//Walls
{

%Colliding_Object.Update_Health(10,-1);

}

%this.safeDelete();

}
