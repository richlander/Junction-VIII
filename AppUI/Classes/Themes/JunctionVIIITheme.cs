﻿using AppUI;
using System.Windows;
using System.Windows.Media;

namespace AppUI.Classes.Themes
{
    public class JunctionVIIITheme : ITheme
    {
        public string Name { get => "JunctionVIII"; }

        public string PrimaryAppBackground
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIBackgroundColor") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string SecondaryAppBackground
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIISecondaryBackgroundColor") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string PrimaryControlBackground
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIControlBackground") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string PrimaryControlForeground
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIControlForeground") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string PrimaryControlSecondary
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIControlSecondary") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string PrimaryControlPressed
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIControlPressed") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string PrimaryControlMouseOver
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIControlMouseOver") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string PrimaryControlDisabledBackground
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIControlDisabledBackground") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string PrimaryControlDisabledForeground
        {
            get
            {
                Color? colorResource = App.Current.TryFindResource("JunctionVIIIControlDisabledForeground") as Color?;
                return ThemeSettings.ColorToHexString(colorResource.Value);
            }
        }

        public string BackgroundImageName { get => "JunctionVIII Logo"; }
        public string BackgroundImageBase64 { get => "iVBORw0KGgoAAAANSUhEUgAAAQAAAAEACAYAAABccqhmAAAAAXNSR0IB2cksfwAAAAlwSFlzAAALEwAACxMBAJqcGAAAPsNJREFUeJztnQd4FFXXxyXUFEIITQhgQLC9oOCrCPoKAaSLBFSkqQlVigqhg0IioZeE3kkAkU5CR9pSQwKBUBN6IICCohQV8dX3O985s7thdjMzO7s7d2aT3PM8vyc7SXbv3Lnn/79lyj71FI9cHQAQgNRCQpBQpD8Sg8QhCYgJSbOQidxzQKaFNMv7EyyfFWkhzFJWsNF158EjX4RI5GKBp1kEa3TQPohNgvYx2OhjxoNHrgx4InZPE7orYQKzMVBdQow+tjx4eFyAWfA0pKbeMzeLXW3QaIGMLcToY8+Dh+4B+U/wjsIE3BB45OUAs+hpbhwHXPCOgkYIYUa3GQ8ebgWYRU8r5sx7+T/u3YOfMjMh3WSCYwkJsC0mBpb1HyAwLywcxoQ0FBheq7bAl8FVZKG/0/9OC20rQO9fNzpSYH9cnFAGlaVTkBnQ+kGA0e3Jg4fDgCc9vQk0Fj2J/FpamiDw7Sjw5SjuESjWHgElofNTBQyByiaTmI8msR4NgvaN9pFR8JEBD88MMM/paR6rieitYrcKfSQKvSeKrQuKLrcwFkcRZAxUBxo1aBx8zYCHsQG2Q3y3ggRPIqFeNDeKXS0xOFogQ9PQEOjY9zc6F3jko8CECwYNensSwQaL4Huh4D9GgeQ3YtEQ6BhoZAjUJsFG5wePPBpgHuZTprokfOrlMzDRV2APGBFcBT5BAXBsWYhThtSEBHeNgD4g1Oh84ZFHwiJ8l4b5VtFTYvfGXv5TTHKOOqbj6OBgXJw7RkBtFmZ0/vDIpeGO8En032FP3wdFH4bJzHEPOpYZrk8TuBHwUB+uCp96+0Scz47GOX04Ji1Hewbj1InM4GfXrkPgRsBDPuDJHN+psPb2fbG3N1og+YmZOEVwcVRARlDL6Hzj4SEB5tN5Tq3qU29/IiEBIrG374rJyDEOaoNDrq0V0JuCjc4/HgaFq8LfiMP8oTgU7YbJx/EsVuJIzIWIMToXeegc4OQ8n4S/CpPrCxzmd8dE43g2q5w3gkzg6wN5P8Dc68c5I/zVmExfovB7YGJxchernTcCyo1go/OUB4MA82W7qob7JPxNONTnws8buGAE/PLivBJgfryW6svLLphMMBzn+D0xcTh5h/5o5oedWyykKWKw0fnLw40AJ3p9En40XZePycLJu1AbZzl3yzIfDeS2APNcX1WvT8P9NThEHIA9xGeYIJz8AbU5tb3KMAF/KEnuCDCv8GeqadUkHBJGoPB7Y0Jw8idJ6qcF5Bb8JiNPDXDivP4NHALOD20LfTABOJxxOC24q/7yYn7dgKcFqBzyP8Ih396YGBiIvb7RScfxPLaMjlRrAnyB0FMCVA75rb1+X2xoDkeO8epHAzTSDDE6//N1gPmJsQ6H/Mk4zxtcsiT0K1CAw1EFjRRVBj9LoHfAk/m+YtCQ/9vwcPgcG5TDcZYZDRuqNQG+LqBXgMr5/k0c8kdWqQJfYENyOK4yFEeON9VdN0D/xE8VsgwwP5Az01FLmHD4Rg1ndPJw8g77Z85UYwKUm/xZAywCzJf0KoqfhvwrcMj/JTYYh6MFg3x8YE6zZrBl5Eg4nZioxgTucRPQOMC80q+42EfiX9y2LfTHRuNw3GUwCn8uCn9ndDSYpkzJ5tiyZfDngwdqjCDEaN3kiVAjfpqjjcH5/gBsOA7HHYag8KfVqQNbsccXC1/MQZwO/HbnjhoT4FcOuhOg4jTfmYQEGInz/QhsPA7HHcZWqwYbIyJkhW/Pj2fPqjGBMKN1lCtDjfj3x8TAVyj+gdh4HI6rRAUFwaqwMNiHonaWG6mp3AS0DjXiTxwwwPDE4eRuhuFwf0mbNrAL5/muiN/KZXVPJw4zWle5IhyJnxb7VoWHwyBsQA7HVWJxnr8N5/nuCF/MydWruQm4G2rEH9+2LQzGBuRwXGECzvM34Tx/P4pWa05xE3A9wMHTe0j8S1H8Q7ARORxnGYnD/Xgc7u/G4T4L8TtpAvzsgDjAfJGPoviXofiHYkNyOM4yCXv9HTjcP4AC1YPjy5apMYEQo3XnEcHFz2HF2KAgWBMWppvwXTCB/H3FIDi4tt8q/mHYmByOWr7C4f4yHO7vweG+EeK3sumbbxwZQP69bBjMd/XJ3mb1J4p/OYp/ODYoh6OWKTjc3xoRYajwrdDpxXHNmjkyAeoA89ddhKDilt514eEwAhuUw1HDKOz1l2Ovb0LRHUTxeQqjX38dYhw/V8BktCZ1DXDwMI+tAwbASGxUDkcNU7HX34a9vtFil2JBhw7QAVN+PXZoDiLBaF3qEmA+1y8bh+nyXmxUDscRkdjrf2vp9Q+h2DwRWof4CNOe7jA87PgxY2FG65NpgIMV/xNxcRBdsqThicXxfMaWKgXrw8IMF7gaugcGQg9Mf9rvE46/hyDEaJ0yCTDP+zPlav1DWhqMRfF/jQeJw1EiBof8+zy417dn3/jxws/VOB2g/b+qfO8AdZDBRutV0wAHi373MjNhWpUqMAoPDoejxOL69QXxH0ZB5UY29+4N47Cju6f86PE0ozWraWCFZL9xgU73xTVsCKOxcTkcOcbgfH8t9qBGC9gVaI1iEI5a6M5D2p5fpw7EYIfnIOKM1q0mAQ6e6LNjwACIxAbmcOSIRvEn4nw/CcWTW+mEUujr7S28prpQveIdnx7M3fcMgIN5f3JsDER5FeBwZJlWMQj2jBwJSVOn5Gr6BgVBmwJPwdo+vYURwRf4mup3Mj5OyQBy93oAKMz7f0xLg4mBJQ1PMI7nQuI/gGIxWrxaMLxmDQhF0c/BaQBtfxYYKJwapHr+qPy9A7nzIiFQON9P8/4Fr9aGb7DyHI4UM6tXE8R/BMWSF5hUvz4MqVYNNvTsIWyPxNefoCFQXSdhR0iaUIjc9fVjYL7JR7ZGm8LDYQxWnMORYmmD+nAwD4mfWN+nj8327Lp1oQsaAD2diOq8zPF6QLDRulYdoDD0T8F5fzRWmMORYhmK32ixsuDg+PE224mffiIYQH/EWvdTyusBuWMqAApD//uZmTAVhztjsbIcjj3fNW8GySiO/ACNcD5G8fdBxMfgtvJ6gGdPBcDB0P9bHOYYnWQcz2RNaBvDRakntL7RHsXf1c4AZlVVvD7As88K4M7JjmGO4tB/HFaQw7EnoWMHwwWpBwn9+kJ3H2/YNXKksN0ZX3+IBmB/PEgrCuGZUwHcsVC5Paah/zQc+o/HynE4Vib7+kAiij8FxZAfWNCmDXRGwc/Hn7TdCQ2ARgGjJY6Ng6mAZ10gBA6e7vMdDv0nYKU4HCtTUPwb85H4iaUdOgg9fkyzpsJ2O3zdEaGnFtsfn7kOpgJGa94mQOFa/2M4nJmIFeJwrExF8W8ND4OjKIL8xPo+vYWLgaaiAdA0gHr/T4VTgU9JHqczymcFIo3WvRCgsPD3+N49mI5D/0lYGQ6HmIbi35YPxW9lBdadzgDsRwOgpxmFW04FSh0r0s595bsGg43Wv+LjvfYMGGB4wnE8h/wufnsW1awpGMBAGQMgEtq2VTIAYx8jBuY7/SQjy2SCyVgBDoeIQfFvR/Efw8TPz9ATi62v6Xh0t0wBlI7dHeUFQeMeK46Fm+T2anXDhjAFd54FqbExcBbnR6yYiUMvVvvuDCYcQbGsZyL2LuLy4mr8Cy5uWK85lxIT4XZqqvBaLAba/vXiRWZQHcXl/Xz2LLOybh054lD8a1Dwn/h4Q7/AQGF7Z5/eggEMRZTyYIHygqAxDw8BhdN+lxITYCruOCseKM+L3I6FeMBZ7r9a6DiyjKSoSJvyVjWoz7S863t2QyomvhXaZhnnV6+yKe/vP/5gVtbDrCybsqSYVOd16IBiD0P2jhwJJqQbvqbHmjvKhbPKC4L6nxYEmd6fFv6WvVqbGwA3gByR3w0gumYNwQBo3r8DpwKHo6MFA+hBZwYc5MIsHJUqRKbe4pft/ZMiI2Ea7jBLWBvAIjQA1nVQw2XGBnAkyratVnMDcDnUGMD0+vWF8/4keur9kywG0M1yNaCjfCBtKUSYngZgktoD6v3noFPF4M6yhLUBLEYDYF0HNehhAOLy1nADcDnUGMCKDh2EOwD7+nhn/47m/7QOEFXAcT6QthRyX59RACj0/kfQoWJxR1nD2gCWoAHoUQ9HsDaA5Cjb9mJtAFko+OOY9FayGBvABTQAcXmsDUBclph9X32V/XpxmzYQj9Dr/TgN+AaFT1MAely4mpzYGa74DUNhehiASapk6v3noUNNx51kDWsD6FslWLhKSww1kB51E8PaANaiYYvrOKr+20zLS5w8CYa+UScb2mYZ8z7rZVPeb7/+yqysy6mpNmVZOYZ13IlClzKGhObNYBzmVU869irza56RowBQOO+fjMmklzBYG0Cn4GBohNUVMzAPGsBSbDNxHb98m60BLP1qJHxcqWI2tM0yoj9436a8Bz//zKys9MOHbcqyQgawPjwMFjRrJmkAkRYDGImozQsHowB2ZwRA5kk/1PvPR2eagTunB0YYAD26Sa/6WbnCDcCt8AQDSEUDoCF/ZLVqcAJFT2awskMH4fUufP2VxQCGI2rzYr7yKIDNdQFgvuZfMlIwkWbijukFawPojAbQGKssZnAB/epnRQ8DENexPzcAl0PJAKJQ/LPr1xdEPxd/DgoMFF5vRgOgJwL1ooeCOJlfKcpnBIJZGIBkidT7L61aBWbhTunFQwMMgG7Z1LOOs/KoAXyCorDC2gDGogGIy2NtAOKyrKxo314QOBlAGop+OU4FvvDxFl7vjogQ/tbLMvx3JjcWKl8XoO23CoH5fn/JO/4y4uNgdsECusLcAKqgAWCjiBnqpW8diat6GICojv0ZLwLmJwPoHFQBmvn7w+e+3vCZ11Mw4eUagujX4bx/uK/ZAFKio4W/ETNcyI8M+asDtX10GCg86DOxUUOYgzujJ3oYwDsoCDFkAHrXk7UBLEMDENdxADcAl+PsoUPwfpky0DIgABr6+sLrhQrBKyidXiju3shENICTKPpENIChuE2viQjL36e5kF+LSymOArR7gCjInPqjBNVbFNwAtAtuANrF0b17BcHbYzWAryoGCYJPxjpPtZgB8Q2OBujvk1zML6VRgFbiryVXwo52bWEu7oTesDaALmgATVAQYoZ56V9PPQxAXEduAK4HGUAtlIs9NLzvg0Sg0K2iFxOJeUV/H+Nifm1spPiFIiFaGIDk4t9f9+7BEhyCzMOd0BsjDGC4l/71zOQG4FZ4igEMQeb4+cBxnPPbG8A4Xx/BAKIQBnpwbzEQFBb/UjF55mPhRsDaAD5GA2iKghAzwkv/erI2gOXYhuI6RjA2gGUo+E9RiFaWMTaAcWgA4vJYG8CrKJnXkTeQekgDZLqlLTe8UQdOoeDtmVMpCPp60ZOBn3I5T5IiBsjtFmk3wB0DkL3uf+WzVWABFm4ERhmA3vXkBuBeWA2gS1AFaFuqFPz600/MyjqJBmCfM8Q8S1uufblmtug3hLbJfh1bvRr0Q/F/jbiaJ/GsFgNB5so/SkyjxM8NQLvI6wbw9XvvQZPifvCalxfUxnT+5c4dZmU5MoBVz1XLFn0kin2FxQRmvPG6YACRbhgAcUF+MdC1LxIBheH//q7hsBALNQojDGCkl/71vJbHDGA5Cj4MhW9lOWMD6Fa/viB8K0YYwHxLWy7x84HTKHiCvhMhrnlT4fX8BvUFAxiJuJMrpEmFCHbFACTP/dPi3yoc/i/CQo3iN8YG8AkaQDNsPDFfeelfTz0MQFzHgXnMALqjAdC83AprA7DPGWKBpS3jLAaQFh0Nw1Hs6zp2ELbjmzeDz+k0IeJOrizTehoAMsN/SsrFWKCRGGEAX3vpX09uAO6FJxjAQlF7kvjP0CXAfXpDquU1XRn4BYp/EOJuvlyUnwY4d4MQKAz/d7drC0uwMCNhbQCfogE0x8YTQwagdz1ZG8C3aADiOg7KowZQ17Iif4+xAdjnDLFI1J7Hsb4kejHbQurDABQ/4W6+kDYVItgZA5Bc/afh/wocasRhYUZihAGM8tK/nte5AbgVn6EB0E1OzSz1M8IAFovakwzgLIpezMGuYcLlwF9apgDu5AtpkzQqE+qnASAz/KeENFr83AC0i7xuAIMa1LepnycaQMqgCEH8X1quA3A3Zy7JTwPUf4sQ/nOm1Ccc6hoO8ViI0bA2gDA0gBbYeGLoK5z1rqceBiCuY14zgMFoAOL6sTSAU2gA9jlDLLG05XI/n2zRr8f9mli9mvD6RHQ09EfxD7ScBnQ3Z/bKTwPU3RsACo/9Wv9sFViKhRiNEQZA12zrXU+9DWBoiGzTaxIk+HAUvpX8YABxovY8h4I/hj0+PdWH5vwHBkYIvxvq6y0sAmqRMyuVzwaEqDEAyWv/fzmZBsuwAE/AKAPQu55ZOhpAaLGiEB0qe+GnJpFfDcDanqextycDmGMxgISOHQQDiK4YJGzP1yjHbu8zye1mjBoDkHx3RmwMLMcP9wRYG0A4GkBLbDwxUV7615O1AaxAA6C6fVDcD8KCKsD499sxLU9vAxiCBiBuQ9YGYJ8zRLyoPVNR/GQCdO8/LfzRNyWTAUzG6UCE5ZkAWuTNKfnHhSlPA8B8+k8y9uHc4lv8cE/gdwMM4Bsv/evJ2gC+i4qCTqVLZQuSG4DrIWcAS0XtmdK3N6TTuX/cr2+bN4WTaAa0vejlGsIawGREi7xZozwNCFYyANnTf/ShRgufG4C2kTh1qo0guQG4HmoMYF9oG0Hw9qwsU0owgG80MgBC4XRgmNPz/xuYiCvwQz0F1gbQFQ2gnbc3tPf3h3e9vKBVAfMDG/Su5w3WBjBtWp42gKFoANR2VlgbgLgsK8tE7bnjjTo5xH8GRwH0P4MsNwRplTtX5E8Hyj8jAGTO/5/GOcV3+KGeAmsD6POvl7KTlIzgXYsB6F1PbgDuBRkAtZ0V1gYgLsvKclF7JlQKggwUvT2LMbcGW24I0ip3jsjfHCS/DgAyl/8ewPn/SvxQT4G1AQyq+4aQoJ1xfmxtyGgv/euZ1w1g3qBBTMvzBAP4VtSeu0PqC4I/hcdhQsUgOIY/aXtiqUDBAEYhWuXOOuV1gJwPCQGFZ/+txw9bhR/qKbA2gCH16kJ4UAUILVI4uyHHeulfz5uMDWAjGkBXFKIV1gbwLSa8taz3AgJgcr9+TMvzBANYIWrPPWgA5+lbgfv2FgS/LrSNsD2tejVhewqiZf78V34dIETKACRv/713Ms1wwRthAO2L+wkN2BwPzVuWrwbjBuBeWA2gbWAg1PXygkl9+zItz1MNIKVrmPAIsO+aNxW2F7zxumAAMzTuZO7IXw+Q874A/GWc1H9emB4DqwsV8ChYG0D/2rWhtaUB3yxgfs4bPdxR73rmRQPoVK4c1EPx0zFlbQDD0ACoHa3cZ2gAp9EAxGVZWSlqzx2v1ITz08wjgHEF8W9kALi9FI2BHhw6saC2OUbalYmc9wXgL9Ok/vNo13BYgx/mSbA2gF44JKPGa4TUsdxOSrcD611PPQygGwrfygTWawAjR0ADnFbRMa2TTwxglag9tz5fDS6g4Im1KP4zY6OF1wn0VeJoAOPRALTMn8PvO3FfAMgsAO76d21Yix/mSbA2gG5VgoXev64lUUPw9QQv/et5K48ZwOyIiGzx5xcDWC1qz41lSmUbgJgtlYOEMwBRaABa5k9iaZULgaCwALgRP2Qdfpgn8QdjA+iOBmDt/d+yNOREL/3rmdcMgAQvNoDJjA1gOBrAe9h2VlgbgLgsK2tE7UkGcBEFb8/BFs2ER4IRWueQwkJgLbEBSF4BeP9kGqzHD/E0WBtADzSA/xQwP9+dbuhoYzEAveuZ1wyABP+G5bn5xKx+bA1gBBpAG0v7tdHBAMRlWVkras+t2NNbRX8Wh//W17QoaDUArXOINCwT/cUGIHkGgBLQaLEbYQD0TEBK0EaihuQG4H6IDYCO7fx8ZgA7nq+WLfqZpQMhMbSN8Ppw397Cg0JZGMAl+YXASIdnAOjNG/BDPA3WBtABDYC+2eVdUUPSlzc6s48bi/vAua9GwpG2bWD3KzWdriO9/86unUzraYQB0LrK25ZpVX4wgHWiNt1mGQGcHhQBsTjfH4cmQNsH0ABGoPij8XdaayU9SvbOwASxAUh2Nce7hkMCfoinwdoAPkADaICNFypispdz+5iMwr+EjSvmOA716PemunVgJ/YGW3BOSGzHxNiDJnEgpL7w9zOYIOdxiPj75UtM67kJDaA7Ct/KRB0MoJ5lWhWqgwGMRAMQtyFrAwi1yxlivSgnqK0pD6h9Z6PYo3y9he2UgRHCIuBIy4VAWmolWf5MQKbYADKl/iMF35yIH+JpsDaAtsHmrwcXN+QUL/X7txfFbC9+V8iLBtBIdEzzgwFsEOXFZhzVWQ1gChrA1EpBwvYxkQHQvQNaamXns1Xkdvme2AAkYxe+eSN+iKehhwG0kDAANfu2jU71YO99GRvWXfKaAUxFA2iTzwwgwS4/rG27t1MH2NGxg/D6LBrCNwXNawD0ABEttbLN0alAUDoF6AFiN8oAWqswgF04jKfG249Detregg5/CudzWog/LxrADBR8aD43gPSvRuZoZ8qhmRYDWKyxARCKpwJB5iGgdPpgE77ZE2FtAO3QANpi44mZ6vWk/O3Yyx/FufpFS09PP+l3aTjH10r8edEASPDiY7pABwMQl8fSAM6gAdjnDJFol7tSOUK/m4vC/9ry5SBa60XhVGAIGUCY1F/u7jPBZnyzJ8LaAMJfegnaFysK7xcqlN2Q9Ly2PdjjH7MI/wo2nBip37lLXjOABfnQADba5e5xHPpL5c70guavCKeHiGqtl7tKNwWBzDUAN+LjYAu+2RN5dP0aq3YUYmi9ujbCINZ/3EVzgec3A1iIgm+HorCykLEBfIUGIC6PtQGIy7KyyS53T1gM4AB2JHOqV8tu6yjL8wBoDUBrvVxVuhYAZB4DRm/aim/2NA68UhP+fvCAWUNSSBlAYveucBUbSk/+4AbgVniCAWy2y18aQVLbrsUpI90SnNS3t7A91tdb2KYHiGitmYvy1wLEyV4ERG/ahm/2JL4v7gPpgyK4AWgURhjA+ygKK6wN4Gs0AHF5rA1AXJaVLXY5nGoxgB1oAPQMwH04/6ft6ZWChG26DkBr3aRHDJDb7QTZi4BOdQ03XPD2HG3RTDhY3AC0CW4A2oVaA7Dm8K7KZsGf/mqksD0XpwORlkVArXVzXP5iIJOsAZzAN23HN3sKu9ExL4+NhkwdDGAYGkAPFISYjWgAVLae6GEA4jpO4gbgcsgZwFa7PE4OqS+07Sns+ddYXhMJFgNYWPApzbVzQt4A0mQfBEJv2oFv9hROduqQfbC4AWgT3AC0CzkD2GaXx4deqSnZ1lv8fAQDmIEGoLV2jjZuKLfbmbKXAdObvsc3ewKH7Q4aNwBtQm8DWISC/wBFYWURYwMYhQYgLo+1AYjLsrLdLpeP1K0j2dZbcYRLZwJi0AC01k/Sv2vL7fY9WQM4gm/aiW82mt3FfeDCoAi4hgfJCmsDGI4G0BMFIWYTGoB4H/SAtQFsRgMQ13EyNwCXQ84Adtjl81Ec9lvbl87/W19ve66a8M1AU9EAtNbQQaX7AUDGAOhNRoufON6iWQ5hcAPQJrgBaBdqDcCaz2e7hsEMP284gD9peyMaAxlALAMD2KtwP4DsswDJAHbhm43EhMOiqyKX5AagbRhhAB+iKKzoYQDi8lgawFk0AHFZVr63y+kknM5S26bgVIB6+/iXawjbm5o3gzFoAPPwd5rryBUDOIQGsBvfbCRnOnWA63hw7DHCADajAUjtC0seMTaAtRMn6moAi1Hw7VEUVhYzNoDRaADi8lgbgLgsKzvtcvoIGgC1bSr2+LTgt/KN14XtvR07QDQawBz8ndY62ueKARxGA9iDbzaKZMuB4gbALpZERsJ/6AEd9EWogYEwsa3s6SJNIj8awC67vN6Po1pq20uWZwKsRyOg7SScCpAB0O+01tJ+VwwgqVpV2FvYyzBOtwuFrGlTJWFtACPQAHqh6MVs6d5Ndn9YoYsBYJJa6Vv/babl5UcD2G2X1/v8fbPbNwHFfxKNgF6f79cHxhYsABMQrbV0oEyg7H7LG0B1NIAiXoaRUrsmZMVMlcQwA5DZH1ZwA3AvPMIAJHI7c1x0jrY+27kjxGJvTSawS2MtHSjrigE8hwZQ1Msw9gX4cgNgbACr0ADoYhV6fn1zbgBuhawBSOT2pcEROdo65dWaZgNANhfRVksHyrlgAEffeBX2ensZSuYEdMrYqTlgbgBvogFUrmjDlh7dJPeFJcwXAaMioT3OO62MaqCDAYjKY24AOMQWl8fUAEx7bcqyslsiry8NjcjR1ifeaQBTi6ABFC4ACcUKaKqjpBeqyu63/JWAddEAfAoaxr5AP1lhcAPQJswGUCAbOm3GMhb362dT3mLGXw8+OqSBTXnsDaBADnZL5La1fddXrQiHeoQLr4983BHGYs9PrCPhaqilpBefldvte7L3AqQ1bwQm34KGcbhaJciaPlUSQwygZzfZ/WGFHgbwESapldE6GIC4PNYGEIkGIC6PtQGIy7KyRyK3r02MFljv4wXLa78stPXhnuEwDsU/EYfsifh7LbV0rN6rcrudKW8ALdAA/Aoaxqk2zbkBcANwKzzCACRy+/KwQYIBJPp6weIXqwttfRm3xxU1G4DWWjr2prIBmKT+ktG7K5j8CxnG5RGDIGvGNEmMMYDusvvDikdXLjOtp2AABQtkw9wAPu9nUx5tswzBAETlMTcAUVlW9kjk9oUBfYX2TSzjB3OrVhJeX5k4FsYV8xLYXVxbLaW1bCy322myzwO4NCwCTCUKGUJyrecha+Y0WQwxgF7dFfeJBdwA3AuPMACJ/D7Tsa3QvqlhneDU8IHC62uTxsJEb7MBbPEvqKmeqDOXCeGBIJJPDLw0HA0goJAhZPTpyg2AG4Db4REGIJHfp9q1yNHWlPOzcL4+Dk0gkQxAQz2RlmUiQdYAMidEwb7AwrpzqGpZuDZlLGTNmibL3w8NMgCFfWIBcwP4Bg2gUIFs6LQZyxAMQFQecwNo2MCmPOYGICrLyl6JHD/euF6Otqacn4dD/3E+BWEl9tpaauryiIFyux0j+1Tgn7duhH2lCuvO6Q9aQtbsaYowN4C30ACeqWjDls+6O9wvrXl0lRuAO+ERBiCR42c6txPal0R/hTo7S3svwvn6OBwFLCcD0FBTP363VG63BQMIlfqLYAClC+vKoWrY+08d61AY3AC0CW4A2oWsAUjk+ekPzZ3c8XfqwZTSftntPaNiabMB4LBdS12RlmUiTNYA/r5/D/aVLaIr53p2hqw5MQ5hbwD1UPSVbNjSu7uqfdMSbgDuhUcYQJmceX6sfm2hfQ89Vw6mY69/Zeo4YXvxK8/BOL+CsJF6bg119duZk3K7HUoGECD1FzKA/eWK6MbRN16AG3gQ1GCEAWxFA1C7f1qhiwEULpDN6IaMDeCLfjbl0TbLiGzUwKY85gYgKsuKqax8rtPPGbRKP/ZrYXt1w7owvnhBWIUGoKW2/syS/SatEFkDoDj8XFnY/3QRXbg4tB/cmBujCsMMQOX+aQU3APfCIwygXM5cPxhcQmjfk20awZSyfpAx7mthO6FlQxjvXxDiyQA01JZCBD9FATI3BB1v8jrsr1CEOSfbNoIb82JUY4gB9Onu1D5qwaNMbgDuhEcYQHnpnL8eO07gzKhB2e29s0ldwQDmBxbSTFukYbl4yhogcznw5dGDYH9QUaYcfDZAOBDcALgBaB0eYQAVpPP+cuTgHO29CUcG43FKMKNkIc30dbbrh3K7nCY2AMlrAa5N/Qb2VyzKlLNd34cb82OcwhAD6Nvd6f10F+YGMAYNoEiBbEY30sEAROXpYgCi8pgbgKgsK6Yg6bxP793Fpq2vTx8HCThcHx9QCCYjWunrcuQguV1OEBuA5LUAd3dshAOVijLj6H9eFCrODcAYA1iHBtABk9RKJGMDWIKCF5e3RAcDEJf3gLEBiMuyYqoonfuZk0YJbZxBIwFLe69/vhxMQPFPwRGAVhq7vWaZ3C7HiA1A+lTgg3tw4JlizLg08gu4sSDWaZgbwH/QAIIr2bC1Xw+X9tUd2BtAFCapVzYkGJZhNoAn5bE3gBCb8tgagMmmLCumytK5T+17ZcwQSKARQs/OwvbS156HCSULQ0ypwppp7O73CtcAiAxA+lQgGUBwMSacat/YZWFwA9AmuAFoF7IG8EzO3D/0QoDQvhn9PoYt2Etvbd9S2F7TpB5MCCwMK8oX0Uxnf95QOAUoDrn/Ot6qDhyoUkxTDr0YANdnjocbC2NdwhAD+LyHy/vrCqejBsPto0lM6ykYQFGvbJgbwJf9bMqjbZYR2TjEprwHPzE0gH0mm7KsmIKlNUBtfGFQD9j5TFFIbNNI2KafE0pZDEADnZF2FSLY3gAkzwRciR4MB5/11pQzn7aGm4tiXeaf34wxAHf22Vni67wAF+Uv4dQkyAA6YpJaiWJsAHEoeHF5cYwNIAoNQFweSwM4hwYgLsvKvqrSGsiaNUEgEacI2z5qKbT53k6tYGLpwrAQDUALnaV/1l5ud9Oesg+QORNwK24mHKzmrRkpb1aFrNkTuAEocGRADyERuAG4Fx5hAM9K6+DquKFCWx/8sDFcxdEwvT4d1lpo99iyRTTR2vXpY+R2N0HKAPpL/efv6afgYHVvzbg86gu4uTjWLQwxgC96uL3faol/4wWYWAYNYBs3AHfCIwygmnodnOr0DkxB8RNaaO3urk1yuxspZQC1pP7z7wf34eDz3ppwqvM7cHNJrNsYYgBf9tBk3x1xZCD2/mULCzA3gGg0gGJe2UQ1bsC0vLj+/WzKo22WEfVOiE15zA1AVJaVfc9Ja+Fy5Bc52v7CsJ4Q+3QRoe2P1Kngtt7+vCm7ABgqZQCy9wScCK0LB1/wcYvDrwRC1pwJ3AAUuIpTowW1gjEBighwA3AvPMIAns+pheOtX5Nsf9JHLM7/KQfotTt6I80qRHAOA1BaCLw6fggcetHHLdL7fqiZUPKqAWynRaByRbLhBuBeeIIB7H/BVgepzf4FVycMlWz/yzGjYXe3DyDT0lEebfCsy3ojzcpEzgVARwuBd3dvgkMv+bgMVTprHlYqLlYTmBvA22gAVSrZIBiARvsvBTV6TLC/jQFc28ENwJ3wCAN40ayBpNqBcH7gJ07lRHK9IJc1R5qViRglA5C+IvDhfThUw9dlLo/5Em7GT9cMQwygfw9N62DP9i7Y++Pwz8qsF8rBLyn7mdZTMABvr2yi3mnAtDzBAETlMTeAJiE25TE3AFFZVvb/yxdSW9SArPkTncqHrHkTBe3s/5cPfE8m4qTmHjsz/1ezDpD2QT04VNPXaU6HNdVcLHnRAL5rXDtb/LHPl4WsnWx7fwpuANqFnAGc/OQdp8VvJQWNY+EzxSCOLp5DLSW9VgqONqrmUHOkVYWQnv+LTCBT6l1XJw2BQy/7OkXS66UgawFWful0TTHEAAb00LweYjZ+2BgmVkDxv1AWLm1nL34KbgDahZQBhJXyh+tLYlzOiRVvvyjkxMLgYpDaqgZcmxEJF7/q5VB3pFWZkJ//O1oH+P38KThcy88pMvp/BLeWTdcc1gYwEg3gMxS9mG1oACzqYiUTe4k1HzSG+/KPb9I81o+Ngk4+XtlENWnAtLy4Af1syqNtlvFN0xCb8lgbgLisLv5FoVdwEGTFxbiVE8lDe0LGxGHZvzveuqZD3f2yd7PcbsrP/x2tA1CktnoJDtf2U8Xx92oyE0teNICfNn/HvF72wQ1Au7AxAN9C0D2orJA37hiAPVfG9neou5T6QcKanUzIz//tTEDyEWGXRveCw6/6qeLKuP7cAFTy8/fr4X9/PWZaJ6ngBqBdWA2Aev6elStk542WBnBj4URICako6GtbDV84UNs3h+4yIjrI7SJpOkCtAcRJfcIvps1w+DU/h5zp0QxuLZ/ODEMMIKIHk7rcS9ppiPgpuAFoF1YD6F6xrE3eZMXHaJYrF0Z8CofeLA2LqnnDpEpFYWct3xzaI43KRM7r/xUMIEzqE2hokfR6cUWS/1MGbiyeBLe+ncGMf35nbAD10QCqVrJhW0RPzetxP/WAYeKnEAzAt2A27A3gc5vyaJtlCAYgKo+pAew3CWX0qPS0Td5kLY3RLF8W1y4P04KLweTKxWBxde8c2ktpVBEe/3BdbhcjnTEA2dOBl775DJLqFJfl/KAOTMWfVwyAxG90cAPQLqwGIIwAGBjAxZmRgvCtbK/ll1N7gzsq7WKwagOwmIBJ6lPubPkWkt4oLsmJdi/DrRUzmGOIAQzsqdn+/54hecW17sENQLuwGkDXcoFCvvR8pgK0C/CB0xOHaJY369v+ByY/U0xg6Qs+OfRH2pQJx6f/JAxAehrw231IaVIJkur525AcUhYyp4+AW9/NYA5rA8g6dxYuHEmy4ZfLF+DxnZtu8+edW0z33ZngBqBdWA2gi38RwQC6lPaHBkW8YFat8prl/bXFE2FO7Qowrao37HytuI3+SJOkTZmIdMUA5KcB0b0h6U1/G872bq6L+PUwgPwQaZiw3YNKQSe/gtlENW3AtMy4iM9tyqNtlvFNsxCb8pgbgKWc8LIB8L5vIWhQ1Asm4pz92pKJmuV+2tj+sJh6f9RccsOykPre88Lr88M6Ke1esNMGYDGBBKlPe3DiABx5yz+bYy0qw434SfDDyhm6wA3Avdi5aAG0wqFqKK2OcwPQJMQGQHTE0YDYALTM/90fvA4pjcrCZeyIafviqDD4Zb/s6r/zw3+RAUhOAyhOfFgTjrxdQuDi6HDckZm6wQ3AtfjjwQNYOjgC2pbyF5KzcTFuAFqFvQEQDckAqhSDq/O+0TT/r8VNgsyZw7O3b62kU+MaDv9FBiA7DcicOQyO1C8Bpz6tCz+smqkr3ACcDxL/nF7doE1JP0H8Vj7iBqBJ2BtA16cDoa1/UZhe3QduLJ3EVA93tsku/tHFP8EuG4DFBOKkPpkWHI40KAHnR3TkBuDhQYuaw9+uC++W8LERP9GOFsiKm4lq1oDpfggGUPxJecwNoHmITXnMDUBUVq/gCsJi4IlB7Zlq4WJUOPx+6bTcbqm/+EfBACSfFUhxeUIfyFo0Bn5YPVNXuAGojwvJSdD/lZfg3YCc4ucGoF3YG0BYmeLw2bOV4MZ3sUy1cANNQCHUXfuvwgQypT794bkU+GHNTN3hBqAu9ixZBH1rPAdNfAtLir8J3baKydrZwvQ2jZjuTzwKvrOovHjGBjAGDUBcHmsDEJdFdCsfCDdWxkJmbIQACy1c27ddbpcyNRG/xQBkFwPvbI3nBuBhQfP9NdGR8GnFctDIu5Ck+Jvaif/rykXh5BfNme5XfjMAYnP90hD3ii8kNX8aLs8aoakObm2YD48fMFj8kzAA2cXAR5np8MPambrCDUA+SPxzP+sOHcqVNIu/mFcO3vWxiN/fzKTnvGF/wxJwbkALpvsWP/Dz7DIJ2mYZY1qE2JTH3ABEZVnZ/KY/TMHjO7eGLyx5M0hTHWRuXyO3O+4v/kmYQJxUSf/772O4s20p7tAs3fjn94eMmjF3x90bN2Bap/bwYZkASeETrX2fJGfXwEIQV9sPkpuWFDgX0ZLp/uVHAzj8TklY+IofTHneW+DQiDBNNPBj4kL45/Ejud1xf/FPwgBkRwG/nUuBH9fN0o1//uAGYB830s/BiPp1ITTQD0JQ6PY0Qtr62Yp/Jd1B1qxkNukDuQG4GnIGcKRJSTjcJADmvewLi2r5wemocE00QJpTiBDNDcBiApJXBtIogBuAcUGLff1rvQStS/rKiv99kfj7VygCu3DIn9K8pA3pg7gBuBqyBtDU9hhnzhzodv7f3rhQSQMmJuK3GIDsKcEHpw7Cj+tn6QI3gCexZXoMdH+mPDTxKywp/iY43/+IkrFEIYGhlYvBAUrKloE5SB/cium+xg/6PHs/CNpmGWNaNLQpj6kBHDDZlGUlLbw23FgaDZcndBPQIv9Jawqhzak/BRPIlCpVGAVsmKUL3AAAHtFlvUMGQnjlctDIp5Aq8U9+0QcO0HC/VaAk6UO4AbgacgaQ0qY8XF84UrPcv71Zsfd3/bp/JwxA9qGhD04f5AagQ5D45/XuAZ2fDpQVfwu6wKeEWfxdSxWC+a/6Qcq7gYqkD+UG4GrIGcARHFkda1cBrsT0zZHH6XNGwPJWNWFJ42ow762gbOh3qz+oAwld6sPhr8Ns3kMaU4gw5gZgMYFMqdKFUUDCbObkZwOgxb6vGrwJH5UtASHeXpK8S9ejY/J1CSgE3UoXhlVv+cPR90o5JGMYewOgfbLC2gCiWza0KY+1AYjLspL87pPje3bou9k5fB2nBTNfKw3Tavg6JK5Jdbi+cgrc3rJIKfczQe1DPzUwANlRwG8ZR+HHxNlMya8GQJf1Dqj9EnxYurik8BshbYsXzE6+3k8Xhq2NA+Bom1KqyBjODcDVkDWA1k+Ob/wb/jD9FV/Y1b0hxDWsqEr8Vua/XRF+OrZHaRfCdBG/yAQypfaCRgE/7VzGDUDj2BO3CPqj+NsE+sqK/33/J+IfFlwMdjcvCUdDS6kmYwQ3AFdD1gDee3J897YoCdNq+jqETML+d7PfrACPZZ73/3//+x89CVSf3l9kALKjgEdZGfDjxtnMyE8GQPP9tdFR0CO4PDQvXkRS/E19vaCDKOmm1PSBg+8FwtF2pZwiYyQ3AFdD1gBCbY/x3lYlYf7rfjDtZd9sptfyhYRGAZAUmrPNDmA70nsuLRuvVHyYruIXmYDs0y1/3reamQH8fuUk/PnDVRsyjyXByZ07dCMNOfH9dtfei+87vm0zpG5JfMLWTfiZOT+PFvu6VS4LTXwLSYq/GS32UbKVNDOzth8cfb+0S5z58i34NXlzDlI3J8CxTRvcZvKH72bvJ0Hb575PtCnrzqHNmpRFDK1b06a8Ayvi4dKejTblZexM1KSshEnRNmVZSW4rfazXhQTANOrpkQSapim0y6neteGf36V7/0cPH6YYIn6LAcheF/Df+z/Dj5tm68b8jq2gd7XKzAl/Bnti/6I2ImxXxh8+rVzO6c/qVbUCdC1fAj4p7Q2fPVtR8n8+Ll8SGvlIL/a1Lv5E/N3KFoalb/rDsQ9Ka05YqcKSya0FXz/nbVPWrpaBzMoipqNBisuLfsmHaXkp7ZSPral1oMPj//DsIdmu/+Hdu00MMwCLCUheHUjx69FtecoAulepAI2pJyZByhBaqrhLZmAPGUKnssXN4pcqh+b7JZ+If1WDEnDsw9JMYG4AorJ2tWJsAK/62ZTH3ADed+/YX5r0iaz4/7h/f6eh4rcYgOw9AsJpwc2zdWF+JzSA6pWZ0poW4BTEbw+NDMg0nC2nV5Xy8H5gMcnPJENoV+JJgg14pijsea8UHPuoDDPCSjM0gOe9bcra1boUWwP4t59NedH/8mVrACRkF4/7ifBq8EfmGTl50R1/tYzWvxC4I5Fye/noRgb8uGU2c1gbwEflA2UF2cyvoICcEbQM8Bber6acHsHloLV/YcnPeQfn++1pyB9oZtizxeAQ9TAdyjBFMIDAQkwQDEBU1i40M1ZlEYIBiMoTDIBheSntXW+fW2snyvb+oOarvvUKyyggU25P7x5cDbe3zmbK/M6toA8KiAW9cDje2K8QNEQRWmnsi8PwEgXhY2xkMfS75vREWNH/iqFRxMeVykiW0eXpEtCiuPR76TM7lnxSzrRXfeEw9i6pncowJ7xM4Rz11IpRL3jblLU7tBSzsogZr/nZlDe2hi/T8o52cK2N0oc3hH/+kH3Yh/pv+tUrQOG04D+PHqJI5zBlx+jeggmwYNCrwfBJ+SI2DK7uDeNq+ioyFOe3nz1TLMd7iW6VfGFYnWowrunrwk/alvo/on/VYhBd48nnLnzLH1I7l9WNKbX9YFItNix5u4RNWQfQ1FiVRaxpEmBT3tIGAUzLO9rJ+eOd1qM6PEyXX/jD6G+03iUDFBYEf7t4lLkJsCB1al+IwWGjmGUhmLRdyjrFxpaBMKeef47PUmJmneLC+5wti5O7yVr+lZL4tX/Yh1YBCguCFHcPrYHb2+bkGrI2TIW41s9BDA4brcx8ozjso6H3x2VdYs/7pWBN0wCbz5Ri4X/84XscDrtaDid3kj6ykaOhv2cs/MkFDU/k9l6YCmyfk2vY9kULiHm9uA3rqUf+tJwmfN+uNCzB0YT482fWNZeRTL2BRuVwcgdpvZ+DhxmHlfrQSKP1rSpA4QrBx7evGi5sNZyeOwhicAguJg7FmoIufTysnKYcxnnihlaBAvRa68/n5A5+SJikJH7SlGct/MkF7miwUk3undgOt3fM8VhuJEyD+PeetxH/zHrFYe9HpeF4eDkOR3OuzJR98r4gGWD1nD9WAQpnBf7v78fw8/7lhgtdjt3D2kEMzvXFbGgdCMe7luNwNOdkv+eU5v0UkUbr2aXAHTfJ1eivX27B7e/nehwZS7+G2SFlIaaufzZz6+PQn5y6+9McjubcO7FNSfykodwx9LcPMJ8VuCdXs0e3zsPtnXM9iu861oIYOl0nYm+nMnC8x9Mcjub8sGmykvg9f9XfUWAFQpRqeP/kDriDwvMEDkR1glgUvJi1rUvBiZ5Pcziacy3uSyVpULB9wq9egRWJkashrQf8krwG7uyaayhX146D2Y3LQeyb/tnMCykBR9GlT3xWnsPRlIzod3Der/gVd55zrb8WAQqnBskEfjItMdQA1nWrB7Fv+duwq3NZONG7PIejKacinodHN84qiT/3nPJTG+BgPeCvX2/Bnd1zDeHAmM45xP9ty5Jwok95DkdTTg18Hqe9sl/pDZAX5v1yAQ7WAx7/lAl39szTlZtbYmBOk3Iw/W3/bGaHBMAxdOq0fhU4HE35ae8CJQlQ5I15v1xgBRWvePgj67SuBrDpi0Y24ie2dCgDaZ9X4HA05eb60Y7En7fm/XIBMl81bo0H6Sa4s3eeKm5ujYELK0bB8dmfw4FxnSF5andhW8176T3T6/vb8G3rQEj7ogKHoyk3NzgUf5zRutQ1QOEiIYr7p3coivfMksGwY0grmNO0XA4RE0vbvwDJ07rLG8e2GOF/xO+Z3TAADvZ8GtK+rMDhaMb1Ff3hn0eKK/55b9HPUYB5UVD2zADFr2mb4I5png03t8fAjmEo/OZPw/SQEg5Z2uFFuJowPsfn0GfY/28iDf0HBHE4mnF+SlNH4s9Ego3WoyEB5puGZM8MUNxDE/gJBUtcWDkKFoUGqxK+PQfHd8n+nLNxQ3IaBQ79U9GtT0YEcTiacMGx+PPuir/aAIXvFqD4v7//gl9T18KFVaNgbgv5Xn/OOwGCiNd/VBq2flxWYGOnMrC4Zcns/1kZVhuSY3vk+Bx67z4c+p8cGMThaMKFqarEn7dX/NUGODg9+L+/H8Pm4e1gOs7R7ZnTJAC2flIOkr/A3ntwRUn2fVYeFrcKlHw/sbFzWdn3cjjOciGmGRe/s+HIBB7/dh/WD3gXpjcKyGZ9xzKQSo47pKIqtn5azub9xIIWgU59BoejxIVYh+KnCDNabx4Z4OAaAYr1Ee/CnKYB8H23cnBqaEWnOT4oCJaFloIZjQOEz9lPV2e58Dkcjj1X5n+oRvyRRuvMowMUnilojdPzwuHU8Epusa3r03D4yyC3P4fDIa4sbA///MnFr0moMYFbWyLh1IhKHI7hUC5y8Wscakzg9p6pcGpkJQ7HMG5tlf1WPC5+d0ONCTxI3wGnvq7E4ejK2bH/gp+TFqkRv2d+i09uCXBwdoDi0Y/n4Ny4GnB6VGUOhzmUa9TxOAg61RdmtH7yRKgxgb/u3YCLc5vD6dGVORxmUI5RrnHx6xxgvmJQ8bJhimuresDpyMocjuZciVe10s8v8mEVYL53INNRC/ycvBhOf/MMh6MJ5ybVFHJKhfgpN/P3tf2sA8x3EZoctcSj2+fg/My34PSYZzgclzk3uSY8OP+9o3SjoDtbg43WR74JUHjSsDXIsa+v7QFnop/hcJzm6vKP4K/7N9SIPwHy2/38nhB40FWdhL17dDGcGRfM4agifdrLQs6oGPJT8NN8RgaYzxA4XBz8E6cEl5a0hDPjgzkcWShHKFdUBF/s85QAFU8XssadgzFwZkIwh2NDegz2+sew13+sqtfn831PDFCxLkDx551zcDm+FZydVIXDgcyVHYWcUBmUY3y+76kBKqcEFHdTF8PZyVU4+ZSMGa8IOaCy1+cX9+SWAJWnCimo8W9uHwxnp1Th5CMyV3eE/z5QtcIPllwKNjqveTgZoOJmImvQEPDCwrfh7NQqnDzM5WWt4MElVef1Ke5ZcogP+XNrgPkSYlULhBR3TyyBC4vrw9mYqpw8RMacWkLbqhzuU5iAX9WXdwKcGA1YjeBcbFVOLuf83Frw05FYZ4TPe/28GmAeDSQ4YwS3dg2GczOqcnIZ5+fXgh8PjHFmnk9hAt7r5/0A88NHM9VmBfUet3YPgXMzn+V4OOcX1EbhRzsrfKHXNzoveegcoPJSYnHcPYlTg1nPcjyM8wtrw08p0+G/D50WPj+vn58DzNOCOFeM4OKyBnBu9rMcA6E2oLZwYo5vDRPw4T4Pa1iMINPZLHp4dSfc2jsE0udW4+jItY2d4f75da4Kn1/Dz0M6KDlcMQIaev50bDpcWPIqpM+rxmEAHVs6xn/eTXe2eSjoVDBf3eehLsDJhUJxPMzEUYEJRwXzq3Hc5ELcq3Btc2fhmP7zl9O9PRc+D/fCHSOg+OVMnJDA6QuqcVRyId4sejp2LoqewsSFz0OzAPPUwORqNlLcv7geftg/FDIWVefYcWHZv+H61i7CMXJD9Fbhh3Lh82AS4OJZA/t4eG0X/HxiBmQmvAcZi6vnS6jut5PHCnN6N0V/D/iqPg+9A8xDzEx3zYDi4fVdcDtlLGRuREOIq57nuLDi30LdqI73L7ndy1sjE8zXcgQbnQs88nGAecgZp0VGW4MM4ee0GXBjbx+4vK4hZMQ/l6vI3NRG2Heqwx8/JmsleIrs3h74MJ+HpwWYRwUmrbJdHGQK9y+vh59PzoDr33eBzM1tIGPpc4ZxYeVrwj6Q0G8fHQu/pMfDn7+4PZyXCxPwRT0euSXA/FASZmYgjv+h4P64nQy/ZT0xiDvHxsKPh4dBFhpFlsUsrmxoKHBx1WuSWP9O/0vcNPURoM8ifkWBUzmPUeT/YyNy+zCBeYjP5/Y8cm+AjmaQy8M6vOei55F3A8xrBpTkqh9UkoeDjgHdkEPPcuTDex75K8A8Ogi1iCCvGwL18FbB0wVWvJfnwcM+4MkIgR5ekmmYXN0PEjvVgerCe3gePFwNMJtCmEVMJvCc0YK1VyehU89Oax38FB0PHnoEmKcQ1LuKDSLOIkiThUwLjr4v4Z6ITIuwTSJxWwUewkWeN+L/Aao9PRyPu8ybAAAAAElFTkSuQmCC"; }
        public HorizontalAlignment BackgroundHorizontalAlignment { get => HorizontalAlignment.Right; }
        public VerticalAlignment BackgroundVerticalAlignment { get => VerticalAlignment.Bottom; }
        public Stretch BackgroundStretch { get => Stretch.None; }
    }
}
