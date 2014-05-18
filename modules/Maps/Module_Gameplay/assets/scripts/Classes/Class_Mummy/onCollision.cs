function Class_Mummy::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==0||%Colliding_Object.SceneGroup==1||%Colliding_Object.SceneGroup==3)//Towers, Defenders
{

//%this.Animation=%this.Animation_Attack;

if (!%this.Bool_Blind)
{

%Colliding_Object.Update_Health(%this.Int_Attack,-1);

if (%this.Joint_ID==-1)
{

%this.Joint_ID=Scene_Carambola.createDistanceJoint(%this,%Colliding_Object,"0 0","0 0",
Vector2Distance(%this.Position,%Colliding_Object.Position),
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
true);

}

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
