function Class_Bard::onRemove(%this)
{

if (isObject(%this.SceneObject_AOE_Sensor))
{

%this.SceneObject_AOE_Sensor.safeDelete();

}

%this.GuiButtonCtrl_Parent.Int_Defender_Count--;

%this.SimSet_Targets.delete();

}
