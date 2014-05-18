function Class_White_Mage::AI_Process(%this)
{

if (!isObject(%this)){return;}

if (%this.Bool_Poisoned)
{

%this.Update_Health(5,-1);

}

/*if (%this.Bool_Blind)
{

return;

}

for (%x=0;%x<%this.SceneObject_AOE_Sensor.SimSet_Targets.getCount();%x++)
{

%Sprite_Target=%this.SceneObject_AOE_Sensor.SimSet_Targets.getObject(%x);

if (!%Sprite_Target.Bool_Targetable){continue;}

if (!isObject(%Sprite_Target))
{

%this.SceneObject_AOE_Sensor.SimSet_Targets.remove(%Sprite_Target);

%x=-1;

continue;

}

%this.Animation=%this.Animation_Cast_Up;

if (%Sprite_Target.Int_Health<100)
{

%Sprite_Target.Update_Health(100-%Sprite_Target.Int_Health,1);

}

%Sprite_Target.Bool_Blind=false;

%Sprite_Target.Bool_Poisoned=false;

}*/

%this.Schedule_AI=schedule(1000,0,"Class_White_Mage::AI_Process",%this);

}
