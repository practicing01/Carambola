function Class_Paladin::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==2||%Colliding_Object.SceneGroup==4)//Offenders
{

%this.Animation=%this.Animation_Attack_Up;

%Colliding_Object.Update_Health(%this.Int_Attack,-1);

%Radius=%this.Size.X;

if (%this.Size.X<%this.Size.Y)
{

%Radius=%this.Size.Y;

}

%Radius*=2;

%String_Objects=Scene_Carambola.pickCircle(%this.Position,%Radius,bit(0)|bit(1)|bit(3),"","collision");

for (%x=0;%x<getWordCount(%String_Objects);%x++)
{

%Sprite_Target=getWord(%String_Objects,%x);

if (%Sprite_Target.SceneGroup!=3&&
%Sprite_Target.getCollisionShapeIsSensor(%Sprite_Target.Collision_Shape_Index)){continue;}

%Sprite_Target.Update_Health(%this.Int_Attack,1);

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
