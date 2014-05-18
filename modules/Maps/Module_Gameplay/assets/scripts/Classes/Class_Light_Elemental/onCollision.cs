function Class_Light_Elemental::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==0||%Colliding_Object.SceneGroup==1||%Colliding_Object.SceneGroup==3)//Towers, Defenders
{

%this.Animation=%this.Animation_Cast;

/*************************************/

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;
Size=%this.Module_ID_Parent.Vector_2D_Explosion_0_Size;
Animation="Module_Gameplay:Animation_Explosion_0";
class="Class_Explosion_0";
//CollisionCallback="true";
SceneLayer=15;

BodyType="static";

SceneGroup=29;//AOE Sensors

Module_ID_Parent=%this.Module_ID_Parent;

//Collision_Shape_Index=-1;

BlendColor="1 1 0 1";

};

/*%Sprite_Explosion.setCollisionGroups(0,1);//Towers, Defenders

%Sprite_Explosion.Collision_Shape_Index=%Sprite_Explosion.createCircleCollisionShape(%this.Module_ID_Parent.Vector_2D_Explosion_Radius);

%Sprite_Explosion.setCollisionShapeIsSensor(%Sprite_Explosion.Collision_Shape_Index,true);
*/
Scene_Carambola.add(%Sprite_Explosion);

/*************************************/

%String_Objects=Scene_Carambola.pickCircle(%this.Position,%this.Module_ID_Parent.Vector_2D_Explosion_Radius,bit(0)|bit(1)|bit(3),"","collision");

for (%x=0;%x<getWordCount(%String_Objects);%x++)
{

%Sprite_Target=getWord(%String_Objects,%x);

if (%Sprite_Target.SceneGroup!=3&&
%Sprite_Target.getCollisionShapeIsSensor(%Sprite_Target.Collision_Shape_Index)){continue;}

%Sprite_Target.Update_Health(%this.Int_Attack,-1);

%Sprite_Target.Bool_Blind=true;

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
