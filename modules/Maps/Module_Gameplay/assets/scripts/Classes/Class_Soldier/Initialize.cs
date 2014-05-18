function Class_Soldier::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Soldier::AI_Process",%this);

}
