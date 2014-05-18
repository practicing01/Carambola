function Class_Mage_AOE_Sensor::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if ((%Colliding_Object.SceneGroup!=3&&%Colliding_Object.SceneGroup!=4)&&
%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%this.SimSet_Targets.getCount()<%this.Module_ID_Parent.Int_Max_Targets&&!%this.SimSet_Targets.isMember(%Colliding_Object))
{

%this.SimSet_Targets.add(%Colliding_Object);

}

}

function Class_Mage_AOE_Sensor::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.SceneGroup==0||%Colliding_Object.SceneGroup==1||%Colliding_Object.SceneGroup==3){return;}

if (%this.SimSet_Targets.isMember(%Colliding_Object))
{

%this.SimSet_Targets.remove(%Colliding_Object);

}

}

function Class_Mage_AOE_Sensor::onRemove(%this)
{

//Scene_Carambola.deleteJoint(%this.Joint_ID);

%this.SimSet_Targets.delete();

}

function Class_Mage::Initialize(%this)
{

%Vector_2D_Size=%this.Size.X*4 SPC %this.Size.Y*4;

%this.SceneObject_AOE_Sensor=new SceneObject()
{

Class="Class_Mage_AOE_Sensor";

Position=%this.Position;

Size=%Vector_2D_Size;

SceneGroup=29;//Sensors

SceneLayer=16;

FixedAngle=true;

DefaultDensity=0;

DefaultRestitution=0;

GravityScale=0;

CollisionCallback="true";

Module_ID_Parent=%this.Module_ID_Parent;

Sprite_Parent=%this;

Collision_Shape_Index=-1;

SimSet_Targets=0;

Joint_ID=-1;

};

%this.SceneObject_AOE_Sensor.SimSet_Targets=new SimSet();

%this.SceneObject_AOE_Sensor.setCollisionGroups(2,4);//Offenders, Collidable Offender Sensors

%Radius=%this.SceneObject_AOE_Sensor.Size.X;

if (%this.SceneObject_AOE_Sensor.Size.X<%this.SceneObject_AOE_Sensor.Size.Y)
{

%Radius=%this.SceneObject_AOE_Sensor.Size.Y;

}

%this.SceneObject_AOE_Sensor.Collision_Shape_Index=%this.SceneObject_AOE_Sensor.createCircleCollisionShape(%Radius);

%this.SceneObject_AOE_Sensor.setCollisionShapeIsSensor(%this.SceneObject_AOE_Sensor.Collision_Shape_Index,true);

Scene_Carambola.add(%this.SceneObject_AOE_Sensor);

%this.SceneObject_AOE_Sensor.Joint_ID=Scene_Carambola.createDistanceJoint(%this.SceneObject_AOE_Sensor,%this,"0 0","0 0",
"0 0",
0,
1,
false);

%this.Schedule_AI=schedule(1000,0,"Class_Mage::AI_Process",%this);

}
