function Class_Ranger::AI_Process(%this)
{

if (!isObject(%this)){return;}

if (%this.Bool_Poisoned)
{

%this.Update_Health(5,-1);

}

if (%this.Bool_Blind)
{

return;

}

for (%x=0;%x<%this.SceneObject_AOE_Sensor.SimSet_Targets.getCount();%x++)
{

%Sprite_Target=%this.SceneObject_AOE_Sensor.SimSet_Targets.getObject(%x);

if (!%Sprite_Target.Bool_Targetable){continue;}

if (!isObject(%Sprite_Target))
{

%this.SceneObject_AOE_Sensor.SimSet_Targets.remove(%Sprite_Target);

%x=-1;

continue;

}

%this.Animation=%this.Animation_Cast_Up;

/**********************/

%Sprite_Projectile=new Sprite()
{

Position=%this.Position;
Size=%this.Module_ID_Parent.Vector_2D_Arrow_Projectile_Size;
Image="Module_Gameplay:Image_Arrow";
class="Class_Arrow";
SceneLayer=14;

SceneGroup=29;//Sensors

Module_ID_Parent=%this.Module_ID_Parent;

Collision_Shape_Index=-1;

CollisionCallback="true";

GravityScale=0;

};

%Sprite_Projectile.Angle=Vector2AngleToPoint(%this.Position,%Sprite_Target.Position);

%Sprite_Projectile.setCollisionGroups(2,4,30);//Offenders, Collidable Offender Sensors, Walls

%Sprite_Projectile.Collision_Shape_Index=%Sprite_Projectile.createPolygonBoxCollisionShape(%Sprite_Projectile.Size);

%Sprite_Projectile.setCollisionShapeIsSensor(%Sprite_Projectile.Collision_Shape_Index,true);

Scene_Carambola.add(%Sprite_Projectile);

%Sprite_Projectile.setLinearVelocityPolar(%Sprite_Projectile.Angle,10);

/**********************/

}

%this.Schedule_AI=schedule(1000,0,"Class_Ranger::AI_Process",%this);

}
