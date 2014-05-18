function Class_Carambola_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Carambola.setCameraZoom(Window_Carambola.getCameraZoom()+$pref::Carambola::cameraMouseZoomRate);

}

function Class_Carambola_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Carambola.setCameraZoom(Window_Carambola.getCameraZoom()-$pref::Carambola::cameraMouseZoomRate);

}
