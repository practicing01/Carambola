function Class_Berserk::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Berserk::AI_Process",%this);

%this.Int_Attack=20;

}
