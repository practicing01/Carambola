function Class_Berserk::AI_Process(%this)
{

if (!isObject(%this)){return;}

if (%this.Bool_Poisoned)
{

%this.Update_Health(5,-1);

}

%this.Schedule_AI=schedule(1000,0,"Class_Berserk::AI_Process",%this);

}
