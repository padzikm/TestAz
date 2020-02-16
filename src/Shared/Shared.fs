namespace Shared

type Counter = { Value : int }

type Specialisation =
    | Racing
    | Dancing
    | Fighting

type Trainer = {Name: string
                Specialisation: Specialisation}
                