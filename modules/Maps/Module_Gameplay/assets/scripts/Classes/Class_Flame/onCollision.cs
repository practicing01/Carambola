function Class_Flame::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;
Size=%this.Module_ID_Parent.Vector_2D_Explosion_0_Size;
Animation="Module_Gameplay:Animation_Explosion_0";
class="Class_Explosion_0";
SceneLayer=14;

Module_ID_Parent=%this.Module_ID_Parent;

CollisionCallback="true";

GravityScale=0;

};

%Sprite_Explosion.setCollisionGroups(2,4);//Offenders, Collidable Offender Sensors

%Radius=%Sprite_Explosion.Size.X;

if (%Sprite_Explosion.Size.X<%Sprite_Explosion.Size.Y)
{

%Radius=%Sprite_Explosion.Size.Y;

}

%Sprite_Explosion.Collision_Shape_Index=%Sprite_Explosion.createCircleCollisionShape(%Radius);

%Sprite_Explosion.setCollisionShapeIsSensor(%Sprite_Explosion.Collision_Shape_Index,true);

Scene_Carambola.add(%Sprite_Explosion);

%this.safeDelete();

}
