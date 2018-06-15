
DotNet.LoadAssembly "D:\\workspace\\aga_max_plugin\\collection\\maxscript_csharp_example\\maxscript\\csharptomaxscript.dll"

struct Integration
(
    unInst = undefined,

    fn onCreateSphere obj args = 
    (
        sphere segs:62 wireColor:white
    ),

    fn onCreateLight obj args = 
    (
        new_light=Omnilight()
        new_light.color = Color args.LightColor.R args.LightColor.G args.LightColor.B
    ),

    fn initialize =
    (
        
    ),

    fn ui = 
    (
        rollout r_MaxScriptIntegration ".NET Integration" width:300 height:400
        (
            local dotnet_object = "MaxScriptIntegrationDemo.MaxScriptIntegrationDemoControl"
            local custom_control = DotNetObject dotnet_object
            
            DotNetControl dnc_dotNetPanel "system.windows.forms.panel" width:280 height:360
            
            button btn_sayHello "Say Hello" across:2 align:#center
            button btn_sayGoodbye "Say Goodbye And Leave" align:#center
            
            on r_MaxScriptIntegration open do
            (
                DotNet.AddEventHandler custom_control "CreateCircle" OnCreateSphere
                DotNet.AddEventHandler custom_control "CreateLight" OnCreateLight
                
                dnc_dotNetPanel.Controls.Add custom_control
            )
            
            on btn_sayHello pressed do
            (
                custom_control.SayHelloUserControl()
            )
            
            on btn_sayGoodbye pressed do
            (
                custom_control.Say "Goodbye! Press OK to close the Max rollout."
                destroyDialog r_MaxScriptIntegration
            )
        )

        createDialog r_MaxScriptIntegration
        unInst = r_MaxScriptIntegration
    ),

    fn run = 
    (
        if unInst == undefined then 
        (
            ui()
        )
        else 
        (
            DestroyDialog unInst 
            unInst = undefined 
        )
    )
)

integration = Integration()
integration.initialize()
integration.run()