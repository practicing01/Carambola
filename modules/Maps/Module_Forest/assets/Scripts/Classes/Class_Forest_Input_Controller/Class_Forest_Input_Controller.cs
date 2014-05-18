function Class_Forest_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

if (%this.Module_ID_Parent.Bool_Casting_Tower)
{

//%this.Module_ID_Parent.Bool_Casting_Tower=false;

%this.Module_ID_Parent.Cast_Towers(%Vector_2D_World_Position);

}

}

function Class_Forest_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{

%this.Module_ID_Parent.Int_Casting_Interval_Counter=0;

}

function Class_Forest_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

%this.Module_ID_Parent.Int_Casting_Interval_Counter++;

if (%this.Module_ID_Parent.Int_Casting_Interval_Counter>=%this.Module_ID_Parent.Int_Casting_Interval)
{

%this.Module_ID_Parent.Int_Casting_Interval_Counter=0;

if (%this.Module_ID_Parent.Bool_Casting_Tower)
{

//%this.Module_ID_Parent.Bool_Casting_Tower=false;

%this.Module_ID_Parent.Cast_Towers(%Vector_2D_World_Position);

}

}

}
