import { Checkbox, FormControlLabel } from "@mui/material";
import { UseControllerProps, useController } from "react-hook-form"

interface Props extends UseControllerProps {
    label: string;
    //disabled: boolean
}

const AppCheckbox = (props: Props) => {
    const {field} = useController({...props, defaultValue: false})
 //   console.log(props.disabled)
  return (
    <FormControlLabel
        control={
            <Checkbox
                {...field}
                checked={field.value}
                color='secondary'
              //  disabled={field.disabled}
               // disabled={props.disabled}
            />
        }
        label={props.label}
        
    />
  )
}
export default AppCheckbox