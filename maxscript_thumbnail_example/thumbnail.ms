fn generate_thumbnail width:renderWidth height:renderHeight= 
(
    current_max_file_name = getFileNameFile maxFileName
    thumbnail_output_path = maxFilePath + current_max_file_name + ".bmp"

    if $camera001 != undefined then
        render camera:$camera01 outputwidth:width outputheight:height outputFile:thumbnail_output_path vfb:false
    else 
        render outputwidth:width outputheight:height outputFile:thumbnail_output_path vfb:false
)

generate_thumbnail()