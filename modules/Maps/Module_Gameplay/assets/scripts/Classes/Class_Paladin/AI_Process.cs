function Class_Paladin::AI_Process(%this)
{

if (!isObject(%this)){return;}

if (%this.Bool_Poisoned)
{

%this.Update_Health(5,-1);

}

if (%this.Bool_Blind)
{

%this.Bool_Blind=false;

}

%this.Schedule_AI=schedule(1000,0,"Class_Paladin::AI_Process",%this);

}
