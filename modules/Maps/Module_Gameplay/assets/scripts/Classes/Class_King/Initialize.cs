function Class_King::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_King::AI_Process",%this);

}
