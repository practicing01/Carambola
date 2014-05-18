function Class_Monk::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Monk::AI_Process",%this);

}
