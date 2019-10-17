# 动态加载AssetsBundles中带光照贴图的模型

步骤：
1.摆放好场景物体，设为static非batch ,手动烘焙场景（不能用AutoGenerate）
2.需要打包的物体挂载PrefabLightmapData.cs脚本
3.将需要被打包的物体中所有mesh Renderer和场景lightmaps引用赋值绑定到PrefabLightmapData的RendererInfo属性中
4.点击Assets->Bake Prefeb Lightmaps
5.将物体制作为prefeb，然后设置AssetBundle包名，打包后可将原先的被打包物体删除
6.Assets->Build AssetsBundle打包
7.加载AB包中的物体到烘焙的场景中（必须是原先烘焙好的场景）