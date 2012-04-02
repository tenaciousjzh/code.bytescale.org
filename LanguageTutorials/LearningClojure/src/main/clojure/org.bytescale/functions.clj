(ns org.bytescale.functions)

(defn basic-item-total [price quantity]
  (* price quantity))

(defn with-line-item-conditions [f price quantity]
  {:pre [(> price 0) (> quantity 0)]
   :post [(> % 1)]}
  (apply f [price quantity]))

(def item-total (partial with-line-item-conditions basic-item-total))