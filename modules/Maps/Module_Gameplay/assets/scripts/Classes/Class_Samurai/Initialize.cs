function Class_Samurai::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Samurai::AI_Process",%this);

}
