function Class_Warrior::Initialize(%this)
{

%this.Int_Health=200;

%this.Int_Attack=20;

%this.Schedule_AI=schedule(1000,0,"Class_Warrior::AI_Process",%this);

}
