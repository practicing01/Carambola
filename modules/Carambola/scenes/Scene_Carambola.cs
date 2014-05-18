function Window_Create_Carambola()
{

if (!isObject(Window_Carambola))
{

new SceneWindow(Window_Carambola);   

Window_Carambola.Profile=Gui_Profile_Window_Carambola;

Canvas.setContent(Window_Carambola);                     

}

Window_Carambola.stopCameraMove();
Window_Carambola.dismount();
Window_Carambola.setViewLimitOff();
Window_Carambola.setRenderGroups(Carambola.All_Bits);
Window_Carambola.setRenderLayers(Carambola.All_Bits);
Window_Carambola.setObjectInputEventGroupFilter(Carambola.All_Bits);
Window_Carambola.setObjectInputEventLayerFilter(Carambola.All_Bits);
Window_Carambola.setLockMouse(true);
Window_Carambola.setCameraPosition(0,0);
Window_Carambola.setCameraZoom(1);
Window_Carambola.setCameraAngle(0);

Carambola.Resolution=getRes();
%Y_Times_100=100*Carambola.Resolution.Y;
%Cam_Y=%Y_Times_100/Carambola.Resolution.X;

Window_Carambola.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Carambola_Overlay))
{

new GuiControl(Gui_Carambola_Overlay)
{

Position="0 0";
Extent=Carambola.Resolution;
Profile=gui_profile_modalless;

};   

Window_Carambola.addGuiControl(Gui_Carambola_Overlay);

Gui_Carambola_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Carambola()
{
    
if (isObject(Window_Carambola))
{

Window_Carambola.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Carambola()
{

if (isObject(Scene_Carambola))
{

Scene_Carambola.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Carambola))
{

error("Cannot set Carambola Scene to Window as the Scene is invalid.");
return;

}
    
Window_Carambola.setScene(Scene_Carambola);

Window_Carambola.stopCameraMove();
Window_Carambola.dismount();
Window_Carambola.setViewLimitOff();
Window_Carambola.setRenderGroups(Carambola.All_Bits);
Window_Carambola.setRenderLayers(Carambola.All_Bits);
Window_Carambola.setObjectInputEventGroupFilter(Carambola.All_Bits);
Window_Carambola.setObjectInputEventLayerFilter(Carambola.All_Bits);
Window_Carambola.setLockMouse(true);
Window_Carambola.setCameraPosition(0,0);
Window_Carambola.setCameraZoom(1);
Window_Carambola.setCameraAngle(0);

Carambola.Resolution=getRes();
%Y_Times_100=100*Carambola.Resolution.Y;
%Cam_Y=%Y_Times_100/Carambola.Resolution.X;

Window_Carambola.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Carambola()
{

//Scene_Destroy_Carambola();

//new Scene(Scene_Carambola);

if (!isObject(Window_Carambola))
{

error("Carambola: did not create scene; no window available.");

//error("Carambola: Created scene but no window available.");

return;

}

Scene_Destroy_Carambola();

new Scene(Scene_Carambola);

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Carambola to use an invalid Scene.");
return;

}
   
Scene_Destroy_Carambola();

%Scene.setName("Scene_Carambola");

//%Scene.class="Class_Scene_Carambola";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Carambola::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/
