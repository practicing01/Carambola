function Class_Queen::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Queen::AI_Process",%this);

}
