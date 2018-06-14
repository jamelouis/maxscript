include "includes.ms"

fn batch_thumbnail batch_path = 
(
	print batch_path
    maxFiles = #()
    files = getFiles ( batch_path + "\\*.max")

    for file in files do
    (
        loadMaxFile file quiet:true allowPrompts:false
        include "batch_maxscript_code.ms"
        resetMaxFile #noPrompt
    )
)