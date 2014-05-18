function Class_Paladin::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Paladin::AI_Process",%this);

}
