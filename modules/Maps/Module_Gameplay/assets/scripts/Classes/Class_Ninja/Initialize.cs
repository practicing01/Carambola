function Class_Ninja::Initialize(%this)
{

%this.Schedule_AI=schedule(1000,0,"Class_Ninja::AI_Process",%this);

%this.Bool_Targetable=false;

%this.setBlendColor("1 1 1 0.5");

}
