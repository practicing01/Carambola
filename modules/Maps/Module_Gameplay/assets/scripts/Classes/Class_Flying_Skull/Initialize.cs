function Class_Flying_Skull::Initialize(%this)
{

%this.setSceneGroup(4);//Collidable Offender Sensors

%this.SceneLayer=15;

%this.Int_Speed=10;

%this.setGravityScale(0);

%this.Position.Y-=%this.Size.Y;//*0.5;

%this.setCollisionShapeIsSensor(%this.Collision_Shape_Index,true);

%this.Vector_2D_Direction="-1 -1";

if (getRandom(0,1))
{

%this.Vector_2D_Direction.X=1;

}

%Float_Angle=-90;

if (%this.Vector_2D_Direction.X==1)
{

%Float_Angle=-45;

}
else
{

%Float_Angle=-135;

}

%this.setLinearVelocityPolar(%Float_Angle,%this.Int_Speed);

}
