function Class_Angel::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Angel::AI_Process",%this);

%this.setSceneGroup(3);//Collidable Defender Sensors

%this.SceneLayer=15;

%this.setCollisionShapeIsSensor(%this.Collision_Shape_Index,true);

%this.setBodyType("static");

%this.setBlendColor("1 1 1 0.5");

}
